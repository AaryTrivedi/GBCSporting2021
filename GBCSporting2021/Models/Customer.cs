using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GBCSporting2021.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }

        [Required(ErrorMessage="First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage="Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage="Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "Postal Code is required")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Country is required")]
        public int CountryId { get; set; }
        public Country Country { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [RegularExpression("^\\([0-9]{3}\\)[0-9]{3}-[0-9]{4}$", ErrorMessage="Phone must be in format (999)999-9999")]
        public string Phone { get; set; }
    }
}
