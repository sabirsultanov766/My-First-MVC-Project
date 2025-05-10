using GameStore.DAL.Contexts;
using GameStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameStore.BL.Services
{
    public class GameProductServices
    {
        private GameStoreDBContext _context;

        
        public GameProductServices()
        {
            _context = new GameStoreDBContext();
        }

        public void Create(GameProduct product)
        {
            if(product is not null)
            {

            _context.gameProducts.Add(product);
            _context.SaveChanges();
            }
        }

        public void Update(int? id,GameProduct product)
        {
           
            if(id is null)
            {
                throw new Exception();
            }
            var exProduct = _context.gameProducts.Find(id);
            


            exProduct.Name = product.Name;
            exProduct.Price = product.Price;
            exProduct.ImgUrl = product.ImgUrl;
            exProduct.Genre = product.ImgUrl;

            _context.SaveChanges();
            
    
        }

        public GameProduct? GetById(int id)
        {
            var product = _context.gameProducts.Find(id);
            return product;
        }
        public void Delete(int id)
        {
           var product =  _context.gameProducts.Find(id);
            _context.Remove(product);
            _context.SaveChanges();
        }


    }
}
