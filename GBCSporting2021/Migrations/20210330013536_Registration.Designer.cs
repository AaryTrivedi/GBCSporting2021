﻿// <auto-generated />
using System;
using GBCSporting2021.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GBCSporting2021.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210330013536_Registration")]
    partial class Registration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("GBCSporting2021.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "India"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "Canada"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "USA"
                        },
                        new
                        {
                            CountryId = 4,
                            CountryName = "UK"
                        });
                });

            modelBuilder.Entity("GBCSporting2021.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("CountryId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "123 Test Street",
                            City = "TestCity",
                            CountryId = 1,
                            Email = "abc@test.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Phone = "1231231231",
                            PostalCode = "A1B 2C3"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "123 Test Street",
                            City = "TestCity",
                            CountryId = 2,
                            Email = "ami.cl@test.com",
                            FirstName = "Amilia",
                            LastName = "Clarke",
                            Phone = "1231231232",
                            PostalCode = "A2B 3C4"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "123 Test Street",
                            City = "TestCity",
                            CountryId = 3,
                            Email = "jon.ab@test.com",
                            FirstName = "John",
                            LastName = "Abraham",
                            Phone = "1231231233",
                            PostalCode = "B1B 2C2"
                        },
                        new
                        {
                            CustomerId = 4,
                            Address = "123 Test Street",
                            City = "TestCity",
                            CountryId = 4,
                            Email = "hilary.c@test.com",
                            FirstName = "Hilary",
                            LastName = "Clinton",
                            Phone = "1231231234",
                            PostalCode = "A1A 2C3"
                        });
                });

            modelBuilder.Entity("GBCSporting2021.Models.Incident", b =>
                {
                    b.Property<int>("IncidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateClosed")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOpened")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("TechnicianId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IncidentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TechnicianId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            IncidentId = 1,
                            CustomerId = 1,
                            DateOpened = new DateTime(2021, 3, 29, 21, 35, 36, 40, DateTimeKind.Local).AddTicks(7606),
                            Description = "Could not install",
                            ProductId = 1,
                            TechnicianId = 1,
                            Title = "Could not install"
                        },
                        new
                        {
                            IncidentId = 2,
                            CustomerId = 2,
                            DateOpened = new DateTime(2021, 3, 29, 21, 35, 36, 40, DateTimeKind.Local).AddTicks(8614),
                            Description = "Error importing data",
                            ProductId = 2,
                            TechnicianId = 3,
                            Title = "Error importing data"
                        });
                });

            modelBuilder.Entity("GBCSporting2021.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Code = "TRNY10",
                            Name = "Tournament Master 1.0",
                            Price = 4.9900000000000002,
                            ReleaseDate = new DateTime(2021, 3, 29, 21, 35, 36, 37, DateTimeKind.Local).AddTicks(6303)
                        },
                        new
                        {
                            ProductId = 2,
                            Code = "LEAG10",
                            Name = "League Scheduler 1.0",
                            Price = 4.9900000000000002,
                            ReleaseDate = new DateTime(2021, 3, 29, 21, 35, 36, 40, DateTimeKind.Local).AddTicks(4059)
                        },
                        new
                        {
                            ProductId = 3,
                            Code = "LEGD10",
                            Name = "League Scheduler Deluxe 1.0",
                            Price = 7.9900000000000002,
                            ReleaseDate = new DateTime(2021, 3, 29, 21, 35, 36, 40, DateTimeKind.Local).AddTicks(4099)
                        },
                        new
                        {
                            ProductId = 4,
                            Code = "DRAFT10",
                            Name = "Draft Manager1.0",
                            Price = 4.9900000000000002,
                            ReleaseDate = new DateTime(2021, 3, 29, 21, 35, 36, 40, DateTimeKind.Local).AddTicks(4104)
                        });
                });

            modelBuilder.Entity("GBCSporting2021.Models.Technician", b =>
                {
                    b.Property<int>("TechnicianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TechnicianId");

                    b.ToTable("Technicians");

                    b.HasData(
                        new
                        {
                            TechnicianId = 1,
                            Email = "adt@gmail.com",
                            Name = "Aary Trivedi",
                            Phone = "2342342341"
                        },
                        new
                        {
                            TechnicianId = 2,
                            Email = "cghevariya@gmail.com",
                            Name = "Chintan Ghevariya",
                            Phone = "2342342342"
                        },
                        new
                        {
                            TechnicianId = 3,
                            Email = "spatel@gmail.com",
                            Name = "Shrey Patel",
                            Phone = "2342342343"
                        },
                        new
                        {
                            TechnicianId = 4,
                            Email = "rpatel@gmail.com",
                            Name = "Rutik Patel",
                            Phone = "2342342344"
                        },
                        new
                        {
                            TechnicianId = 5,
                            Email = "npatel@gmail.com",
                            Name = "Nishtha Patel",
                            Phone = "2342342345"
                        });
                });

            modelBuilder.Entity("GBCSporting2021.Models.Customer", b =>
                {
                    b.HasOne("GBCSporting2021.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("GBCSporting2021.Models.Incident", b =>
                {
                    b.HasOne("GBCSporting2021.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GBCSporting2021.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GBCSporting2021.Models.Technician", "Technician")
                        .WithMany()
                        .HasForeignKey("TechnicianId");

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Technician");
                });
#pragma warning restore 612, 618
        }
    }
}
