using GameStore.BL.Services;
using GameStore.DAL.Contexts;
using GameStore.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        private readonly GameProductServices services;

        public ServicesController()
        {
            services = new GameProductServices();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GameProduct product)
        {
            services.Create(product);
            return RedirectToAction("Index", "Panel");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            services.Delete(id);

           return RedirectToAction("Index","Panel");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {

           var product = services.GetById(id);

            if (product is null)
            {
                return NotFound();
            }
           
            
            return View(product);
        }
        
        [HttpPost]
        public IActionResult Update(int id,GameProduct product)
        {
            services.Update(id,product);
            return RedirectToAction("Index", "Panel");
        }

    }
}
