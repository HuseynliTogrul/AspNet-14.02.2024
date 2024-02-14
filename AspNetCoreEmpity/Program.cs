using AspNetCoreEmpity.Models.Contexts;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreEmpity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<DataContext>(
                    cfg =>
                    {
                        cfg.UseSqlServer(builder.Configuration.GetConnectionString("cString"),

                            option =>
                            {
                                option.MigrationsHistoryTable("Migrations");
                            });
                    }

                );


            var app = builder.Build();

            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}