using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DAL.Models
{
    public class GameProduct : BaseProduct
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public string Genre { get; set; }

        public string ImgUrl { get; set; }
        
    }
}
