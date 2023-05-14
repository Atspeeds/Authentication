using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreManager.Domain.InventoryAgg;

namespace StoreManager.Infrastrue.EFCore.Mapping
{
    public class InventoryMapping : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {

            builder.HasKey(x => x.Id);
           


            //Relation 
            builder.HasOne(x => x.Product)
                .WithMany(x => x.Inventories).HasForeignKey(x => x.ProductId);

            builder.OwnsMany(x => x.Oprations, ModelBulder =>
            {
                ModelBulder.Property(x => x.Description).HasMaxLength(500);
                ModelBulder.WithOwner(x => x.inventory).HasForeignKey(x=>x.InvantoryId);
            });
           

        }
    }
}
