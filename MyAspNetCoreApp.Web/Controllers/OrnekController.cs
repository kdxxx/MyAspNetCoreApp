using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class OrnekController : Controller
    {
        public class Product
        {
            public string Name { get; set; }
            public int Id { get; set; } 
        }
        public IActionResult Index()
        {
            // you can carry any data since here is dynamic
            //ViewBag.list = new List<string>() { "ahmet", "mehmet", "veli" }; // use it with foreach
            ViewBag.name = "Asp.Net Core";

            ViewData["age"] = 30;
            ViewData["names"] = new List<string>() { "ahmet", "mehmet", "veli" };

            ViewBag.person = new {Id=1,name="ahmet",age=27};


            ViewBag.Name2 = "ahmet";
            TempData["surname"] = "yıldız";

            var productList = new List<Product>()
            {
                new Product(){Id = 1,Name="Kalem"},
                new(){Id=2,Name="Defter"},
                new(){Id=3,Name="Silgi"},
            };

            return View(productList);
        }
        public IActionResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            return RedirectToAction("Index","Ornek");
            //return RedirectToAction("Index"); // same controller
            //return View();
        }
        public IActionResult Index4()
        {
            return View();
        }
        public IActionResult ParametreView(int id)
        {
            return RedirectToAction("JsonResultParametre","Ornek",new {id=id});
           //return RedirectToAction("JsonResultParametre", "Ornek", new { id = 3 });

        }
        public IActionResult JsonResultParametre(int id)
        {
            return Json(new { Id = id });
        }
        
        public IActionResult ContentResult()
        {
            return Content("Bu bir Content return aka string");
        }
        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, name = "Kalem 1", price = 23 });
        }
        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}
