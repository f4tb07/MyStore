using Microsoft.EntityFrameworkCore;
using Domain ;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.Property(P => P.Name).HasMaxLength(50);
            builder.Property(P => P.Model).HasMaxLength(50);
            builder.Property(P => P.Discription).HasMaxLength(500);
        }
    }
}
