using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
