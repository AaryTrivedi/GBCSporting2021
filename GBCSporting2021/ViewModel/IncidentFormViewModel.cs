using System.Collections.Generic;
using GBCSporting2021.Models;

namespace GBCSporting2021.ViewModels
{
    public class IncidentFormViewModel
    {

        private List<Customer> customers;
        private List<Product> products;
        private List<Technician> technicians;
        private Incident incident;
        private string action;

        public List<Customer> Customers {
            get => customers;
            set => customers = value;
        }
        public List<Product> Products {
            get => products;
            set => products = value;
        }
        public List<Technician> Technicians {
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
