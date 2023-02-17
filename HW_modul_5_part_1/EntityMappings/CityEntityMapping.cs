using AdoNetWinformsApp.Entities;
using AdoNetWinformsApp.EntityMappings;
using HW_modul_5_part_1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_5_part_1.EntityMappings
{
    public class CityEntityMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder
               .Property(x => x.Name)
               .HasMaxLength(DataBaseDefault.StringValueMaxLenght);
            builder.HasOne(x => x.Country)
               .WithMany(x=>x.Cities)
               .HasForeignKey(x => x.CountryId);
        }
    }
}
