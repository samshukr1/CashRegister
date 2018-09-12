using CashRegisterWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegisterWebApi.Data
{
    public class CashRegisterDbContext : DbContext
    {
        public CashRegisterDbContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Item> items { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Customer> customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
        new Item
        {
            Id = 1,
            Name = "Computer",
            Weight = 3.2,
        },
        new Item
        {
            Id = 2,
            Name = "Tablet",
            Weight = 1.4,
        }
    );
        }
    }
}
