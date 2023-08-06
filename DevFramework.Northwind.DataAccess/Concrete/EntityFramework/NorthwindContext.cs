﻿using DevFramework.Northwind.DataAccess.Concrete.EntityFramework.Mappings;
using DevFramework.Northwind.Entities.Concrete;
using System.Data.Entity;

namespace DevFramework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        //Add other entities

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            //Add other mappings
        }
    }
}