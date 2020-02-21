using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace DAL
{
    public class MyStorContex:DbContext
    {
        public MyStorContex( DbContextOptions<MyStorContex> options) : base(options)
        {
        }

        public DbSet<Product>ProductTbl { get; set; }
        public DbSet<ProductOff> OffTbl { get; set; }
        public DbSet<Categury> CateuryTbl { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new BasketConfiguration());
            //modelBuilder.ApplyConfiguration(new BasketItemConfiguration());
            //modelBuilder.ApplyConfiguration(new CateguryConfiguratin());
            //modelBuilder.ApplyConfiguration(new CustomerAddressConfiguration());
            //modelBuilder.ApplyConfiguration(new CustomerCommentConfiguration());
            //modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductOffConfiguration());
            modelBuilder.ApplyConfiguration(new PriceConfiguration());


            base.OnModelCreating(modelBuilder);
        }

    }
}
