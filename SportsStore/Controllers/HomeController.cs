using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;

        public HomeController(IRepository repo) => _repository = repo;

        public IActionResult Index() //=> View(_repository.Products);
        {
            //System.Console.Clear();
            return View(_repository.Products);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _repository.AddProduct(product);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UpdateProduct(long key)
        {
            return View(_repository.GetProduct(key));
        }

        [HttpPost]
        public IActionResult updateProduct(Product product)
        {
            _repository.UpdateProduct(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
