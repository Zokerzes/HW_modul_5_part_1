using AdoNetWinformsApp.Entities;
using AdoNetWinformsApp.EntityMappings;
using HW_modul_5_part_1.Entities;
using HW_modul_5_part_1.EntityMappings;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AdoNetWinformsApp
{
    public class CountryContext : DbContext
    {         //  ||
        //таблицы \/
        
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder
                .UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
                .UseLazyLoadingProxies();  //ленивая загрузка
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(CityEntityMapping).Assembly);
        }
    }
}
