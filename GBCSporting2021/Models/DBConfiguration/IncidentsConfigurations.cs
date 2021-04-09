using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021.Models.DBConfiguration
{
    internal class IncidentsConfigurations : IEntityTypeConfiguration<Incident>
    {

        public void Configure(EntityTypeBuilder<Incident> entity)
        {
            entity.HasData(
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
        }

    }
}
