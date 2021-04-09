using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021.Models.DBConfiguration
{
    internal class CountriesConfigurations : IEntityTypeConfiguration<Country>
    {

        public void Configure(EntityTypeBuilder<Country> entity)
        {
            entity.HasData(
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
        }

    }
}
