using Microsoft.EntityFrameworkCore;
using Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InternetstorDataAcsessLayer
{
    public class CateguryConfiguratin : IEntityTypeConfiguration<Categury>
    {
        public void Configure(EntityTypeBuilder<Categury> builder)
        {
            builder.ToTable("CateguryTBl");
            builder.Property(B=>B.Name).HasMaxLength(50);
        }
    }
}
