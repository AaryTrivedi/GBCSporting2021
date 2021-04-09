using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021.Models.DBConfiguration
{
    internal class ProductsConfigurations : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasData(
                new Product
                {
                    ProductId = 1,
                    Code = "TRNY10",
                    Name = "Tournament Master 1.0",
                    Price = 4.99,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 2,
                    Code = "LEAG10",
                    Name = "League Scheduler 1.0",
                    Price = 4.99,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 3,
                    Code = "LEGD10",
                    Name = "League Scheduler Deluxe 1.0",
                    Price = 7.99,
                    ReleaseDate = DateTime.Now
                },
                new Product
                {
                    ProductId = 4,
                    Code = "DRAFT10",
                    Name = "Draft Manager1.0",
                    Price = 4.99,
                    ReleaseDate = DateTime.Now
                }
            );
        }

    }
}
