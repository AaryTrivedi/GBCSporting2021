using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GBCSporting2021.Models
{
    public class Incident
    {
        public int IncidentId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        
        public int? TechnicianId { get; set; }
        public Technician Technician { get; set; }
        public DateTime DateOpened { get; set; }
        public DateTime? DateClosed { get; set; }
    }
}
