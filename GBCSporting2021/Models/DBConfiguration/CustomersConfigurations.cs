using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021.Models.DBConfiguration
{
    internal class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {

        public void Configure(EntityTypeBuilder<Customer> entity)
        {
            entity.HasData(
                new Customer
                {
                    CustomerId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Address = "123 Test Street",
                    City = "TestCity",
                    PostalCode = "A1B 2C3",
                    CountryId = 1,
                    Email = "abc@test.com",
                    Phone = "1231231231"
                },
                new Customer
                {
                    CustomerId = 2,
                    FirstName = "Amilia",
                    LastName = "Clarke",
                    Address = "123 Test Street",
                    City = "TestCity",
                    PostalCode = "A2B 3C4",
                    CountryId = 2,
                    Email = "ami.cl@test.com",
                    Phone = "1231231232"
                },
                new Customer
                {
                    CustomerId = 3,
                    FirstName = "John",
                    LastName = "Abraham",
                    Address = "123 Test Street",
                    City = "TestCity",
                    PostalCode = "B1B 2C2",
                    CountryId = 3,
                    Email = "jon.ab@test.com",
                    Phone = "1231231233"
                },
                new Customer
                {
                    CustomerId = 4,
                    FirstName = "Hilary",
                    LastName = "Clinton",
                    Address = "123 Test Street",
                    City = "TestCity",
                    PostalCode = "A1A 2C3",
                    CountryId = 4,
                    Email = "hilary.c@test.com",
                    Phone = "1231231234"
                }
            );
        }

    }
}
