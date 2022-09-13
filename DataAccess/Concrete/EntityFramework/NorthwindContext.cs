using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
   public class NorthwindContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");   //Hangi veritabanına bağlanacağını buldu
        }

        public DbSet<Product> Products { get; set; }  //Hangi class hangi tabloya denk geliyo
        public DbSet<Category> Categorys { get; set; }   
        public DbSet<Customer> Customers { get; set; }  
                                                      
    }
}
