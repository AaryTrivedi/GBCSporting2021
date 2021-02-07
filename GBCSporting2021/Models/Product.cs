using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
