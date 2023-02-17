
using AdoNetWinformsApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AdoNetWinformsApp
{
    public class WarehouseContext : DbContext
    {         //  ||
        //таблицы \/
        
        public DbSet<Country> Countries { get; set; }
        public DbSet<Cities> Cities { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    builder
        //        .UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
        //        .UseLazyLoadingProxies();  //ленивая загрузка
        //}

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.ApplyConfigurationsFromAssembly(typeof(GoodEntityMap).Assembly);
        //}
    }
}
