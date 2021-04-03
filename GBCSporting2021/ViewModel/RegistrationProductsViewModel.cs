using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021.Models;

namespace GBCSporting2021.ViewModels
{
    public class RegistrationProductsViewModel
    {

        private List<Product> products;
        private List<Registration> registrations;
        private Customer customer;
        [Range(0, int.MaxValue, ErrorMessage="Please select a valid product.")]
        private int productId;

        public List<Registration> Registrations
        {
            get => registrations;
            set => registrations = value;
        }

        public List<Product> Products
        {
            get => products;
            set {
                products = value;
                products = products
                            .Where(p => registrations.FindIndex(r => r.ProductId == p.ProductId) < 0)
                            .ToList();
            }
        }

        public Customer Customer
        {
            get => customer;
            set => customer = value;
        }

        public int ProductId
        {
            get => productId;
            set => productId = value;
        }

    }
}
