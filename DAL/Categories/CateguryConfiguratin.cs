using Microsoft.EntityFrameworkCore;
using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DAL
{
    public class CateguryConfiguratin : IEntityTypeConfiguration<Categury>
    {
        public void Configure(EntityTypeBuilder<Categury> builder)
        {
            builder.ToTable("CateguryTBl");
            builder.Property(B=>B.Name).HasMaxLength(50);
            builder.HasData(
                new Categury 
                {
                    ID = 1,
                    Name = "C1",
                    ProductList=new List<Product> 
                                                 { 
                                                    new Product { ID=1},
                                                    new Product { ID=4}
                                                 } 
                },
                new Categury
                {
                    ID = 1,
                    Name = "C2",
                    ProductList = new List<Product>
                                                 {
                                                    new Product { ID=3},
                                                    new Product { ID=5}
                                                 }
                }
                );
        }
    }
}
