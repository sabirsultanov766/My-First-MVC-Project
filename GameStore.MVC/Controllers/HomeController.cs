using GameStore.DAL.Contexts;
using GameStore.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameStoreDBContext _context;

        public HomeController()
        {
            _context = new GameStoreDBContext();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OurShop()
        {
            List<GameProduct> products = _context.gameProducts.ToList();
            return View(products);
        }
    }
}
