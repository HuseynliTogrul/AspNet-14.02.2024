using AspNetCoreEmpity.Models.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace AspNetCoreEmpity.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext db;

        public HomeController(DataContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            //var db = new DataContext();
            var sizes = db.Sizes.ToList();

            return Json(sizes);
        }

        public IActionResult GetJson()
        {
            return Json(
                new
                {
                    error = true,
                    message = "Duzgun deyil!"
                });
        }
    }
}
