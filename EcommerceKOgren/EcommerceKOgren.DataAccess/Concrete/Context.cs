using EcommerceKOgren.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceKOgren.DataAccess.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public Context()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().HasKey(f => new
            {
                f.OrderDetailId,
                f.ProductId
            });
            //modelBuilder.Entity<Category>()
            //.HasData(
            //new Category { CategoryName = "Cold Drinks" },
            //new Category { CategoryName = "Hot Drinks" },
            //new Category { CategoryName = "Meals" },
            //new Category { CategoryName = "Desserts" }
            //);
        }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<City>? Cities { get; set; }
        public DbSet<County>? Counties { get; set; }
        public DbSet<Country>? Countries { get; set; }
        public DbSet<Colors>? Colors { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Filter>? Filters { get; set; }
        public DbSet<OrderDetail>? OrderDetails { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Sizes>? Sizes { get; set; }
        public DbSet<Supplier>? Suppliers { get; set; }
        public DbSet<Unit>? Units { get; set; }
    }
}
