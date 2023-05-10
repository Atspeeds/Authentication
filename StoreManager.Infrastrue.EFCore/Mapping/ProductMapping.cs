using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManager.Domain.ProductAgg;

namespace StoreManager.Infrastrue.EFCore.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.Name).HasMaxLength(265).IsRequired();
            builder.Property(x => x.ShortDescription).HasMaxLength(500);
            builder.Property(x => x.Description).HasMaxLength(1000).IsRequired();
            builder.Property(x => x.Code).HasMaxLength(500);


        }
    }
}
