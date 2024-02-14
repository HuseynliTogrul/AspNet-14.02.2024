﻿using AspNetCoreEmpity.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreEmpity.Models.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options)
            :base(options)
        {

        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    //string cString = @"Server=DESKTOP-IIPAPM5\SQLEXPRESS;Database=myDataBase;Trusted_Connection=True;MultipleActiveResultSets=true;";

        //    string cString = "Server=JUPITER16;Database=myDataBase;User Id=shop;Password=query;MultipleActiveResultSets=true;";
        //    optionsBuilder.UseSqlServer(cString);
        //}

        public DbSet<Size> Sizes { get; set; }
    }
}
