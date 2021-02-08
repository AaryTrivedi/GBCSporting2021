using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        
        [Required(ErrorMessage = "Code cannot be empty")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name cannot be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price cannot be empty")]
        public double Price { get; set; }

        [Required (ErrorMessage = "Date cannot be empty")]
        public DateTime ReleaseDate { get; set; }
    }
}
