using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using GBCSporting2021.Models;

namespace GBCSporting2021.ViewModels
{
    public class IncidentFormViewModel
    {

        private List<SelectListItem> customers;
        private List<SelectListItem> products;
        private List<SelectListItem> technicians;
        private Incident incident;
        private string action;

        public List<SelectListItem> Customers {
            get => customers;
            set => customers = value;
        }
        public List<SelectListItem> Products {
            get => products;
            set => products = value;
        }
        public List<SelectListItem> Technicians {
            get => technicians;
            set => technicians = value;
        }
        public Incident Incident {
            get => incident;
            set => incident = value;
        }
        public string Action {
            get => action;
            set => action = value;
        }

    }
}
