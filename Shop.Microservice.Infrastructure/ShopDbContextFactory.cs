using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Shop.Microservice.Infrastructure
{
    internal class ShopDbContextFactory : IDesignTimeDbContextFactory<ShopDbContext>
    {
        public ShopDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ShopDbContext>();
            var connectionString = @"Host=localhost;Port=5432;Database=otus_glazev_test;Username=postgres;Password=123123";
            optionsBuilder.UseNpgsql(connectionString);
            return new ShopDbContext(optionsBuilder.Options);
        }
    }
}
