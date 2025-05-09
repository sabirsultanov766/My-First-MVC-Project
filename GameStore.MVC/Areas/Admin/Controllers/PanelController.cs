using GameStore.DAL.Contexts;
using GameStore.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PanelController : Controller
    {

        private readonly GameStoreDBContext _context;

        public PanelController()
        {
            _context = new GameStoreDBContext();
        }
        public IActionResult Index()
        {
            List<GameProduct> products = _context.gameProducts.ToList();
            return View(products);
        }
        public IActionResult Dashboard()
        {
          
            return View();
        }
    }
}
