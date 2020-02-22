using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL
{

    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImageTbl");
            
      
        }
    }
}
