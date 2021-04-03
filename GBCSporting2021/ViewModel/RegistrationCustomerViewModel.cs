using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;

namespace GBCSporting2021.ViewModels
{
    public class RegistrationCustomerViewModel
    {

        private List<Customer> customers;
        private string id;

        public List<Customer> Customers
        {
            get => customers;
            set => customers = value;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

    }
}
