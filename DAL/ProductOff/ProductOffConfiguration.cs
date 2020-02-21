using Microsoft.EntityFrameworkCore;
using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL
{
    public class ProductOffConfiguration : IEntityTypeConfiguration<ProductOff>
    {
       
        public void Configure(EntityTypeBuilder<ProductOff> builder)
        {
            builder.ToTable("OffTbl");
            builder.Property(O => O.Code).HasMaxLength(10);
        }
    }
}
