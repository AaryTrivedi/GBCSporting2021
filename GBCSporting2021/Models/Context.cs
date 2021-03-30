using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021.Models
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) 
            : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Technician> Technicians { get; set; }

        public DbSet<Registration> Registrations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    CountryName = "India"
                },
                new Country
                {
                    CountryId = 2,
                    CountryName = "Canada"
                },
                new Country
                {
                    CountryId = 3,
                    CountryName = "USA"
                },
                new Country
                {
                    CountryId = 4,
                    CountryName = "UK"
                }
            );

            modelBuilder.Entity<Customer>().HasData(
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

            modelBuilder.Entity<Technician>().HasData(
                new Technician
                {
                    TechnicianId = 1,
                    Name = "Aary Trivedi",
                    Email = "adt@gmail.com",
                    Phone = "2342342341"
                },
                new Technician
                {
                    TechnicianId = 2,
                    Name = "Chintan Ghevariya",
                    Email = "cghevariya@gmail.com",
                    Phone = "2342342342"
                },
                new Technician
                {
                    TechnicianId = 3,
                    Name = "Shrey Patel",
                    Email = "spatel@gmail.com",
                    Phone = "2342342343"
                },
                new Technician
                {
                    TechnicianId = 4,
                    Name = "Rutik Patel",
                    Email = "rpatel@gmail.com",
                    Phone = "2342342344"
                },
                new Technician
                {
                    TechnicianId = 5,
                    Name = "Nishtha Patel",
                    Email = "npatel@gmail.com",
                    Phone = "2342342345"
                }
            );

            modelBuilder.Entity<Product>().HasData(
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

            modelBuilder.Entity<Incident>().HasData(
                new Incident 
                {
                    IncidentId = 1,
                    CustomerId = 1,
                    ProductId = 1,
                    Title = "Could not install",
                    Description = "Could not install",
                    TechnicianId = 1,
                    DateOpened = DateTime.Now,
                    DateClosed = null
                },
                new Incident
                {
                    IncidentId = 2,
                    CustomerId = 2,
                    ProductId = 2,
                    Title = "Error importing data",
                    Description = "Error importing data",
                    TechnicianId = 3,
                    DateOpened = DateTime.Now,
                    DateClosed = null
                }
            );

            modelBuilder.Entity<Registration>().HasData(
                new Registration { 
                    RegistrationId = 1,
                    CustomerId = 1,
                    ProductId = 1
                },
                new Registration
                {
                    RegistrationId = 2,
                    CustomerId = 2,
                    ProductId = 3
                },
                new Registration
                {
                    RegistrationId = 3,
                    CustomerId = 2,
                    ProductId = 1
                },
                new Registration
                {
                    RegistrationId = 4,
                    CustomerId = 1,
                    ProductId = 1
                },
                new Registration
                {
                    RegistrationId = 5,
                    CustomerId = 2,
                    ProductId = 2
                }
            );
        }

    }
}
