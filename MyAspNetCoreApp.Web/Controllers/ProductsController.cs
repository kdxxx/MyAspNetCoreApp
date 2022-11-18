using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Web.Models;

namespace MyAspNetCoreApp.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductRepository _productRepository;
        public ProductsController()
        {
            // everything is in the Ram. 
            _productRepository = new ProductRepository();

            //if (!_productRepository.GetAll().Any()) { 

            //_productRepository.Add(new Product(){Id = 1,Name = "Kalem",Price = 100,Stock = 20});
            //_productRepository.Add(new Product(){Id = 2,Name = "Defer",Price = 140,Stock = 50});
            //_productRepository.Add(new Product(){Id = 3,Name = "Silgi",Price = 300,Stock = 30});
            //}
        }
        public IActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products);
        }
        public IActionResult Remove(int id)
        {
            _productRepository.Remove(id);
            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update(int id)
        {
            return View();
        }

    }
}
