using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarını bağlamak
   public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Proje hangi veri tabanı ile ilişkiliyse onu belirtir
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true"); //Sql server nerde onu söyler
        }
        public DbSet<Product> Products { get; set; } //hangi tablom neye karşılık gelecek
        public DbSet<Category> Categories { get; set; } //Category tablom categories e denk gelecek
        public DbSet<Customer> Customers { get; set; }
    }
}
