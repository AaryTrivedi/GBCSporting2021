using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021.Models.DBConfiguration
{
    public class TechniciansConfigurations : IEntityTypeConfiguration<Technician>
    {
        public void Configure(EntityTypeBuilder<Technician> entity)
        {
            entity.HasData(
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
        }
    }
}
