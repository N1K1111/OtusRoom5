using Microsoft.EntityFrameworkCore;
using Shop.Microservice.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Microservice.Infrastructure
{
    internal class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) { }

        public DbSet <Balance> Balances { get; set;}
        public DbSet <Order> Orders { get; set;}
        public DbSet <Product> Products { get; set;}
        public DbSet <Transaction> Transactions { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



    }
}
