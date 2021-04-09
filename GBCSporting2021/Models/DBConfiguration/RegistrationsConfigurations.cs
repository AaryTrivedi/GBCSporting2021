using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021.Models.DBConfiguration
{
    internal class RegistrationsConfigurations : IEntityTypeConfiguration<Registration>
    {

        public void Configure(EntityTypeBuilder<Registration> entity)
        {
            entity.HasData(
                new Registration
                {
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
