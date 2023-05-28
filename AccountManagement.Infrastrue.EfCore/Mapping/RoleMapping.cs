using AccountManagement.Domain.RoleAgg;
using AccountManagement.Infrastrue.EfCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountManagement.Infrastrue.EfCore.Mapping
{
    public class RoleMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);


            builder.HasMany(x=>x.Users).WithOne(x => x.Role).HasForeignKey(x=>x.RoleId);

            //Role ---> Permissions
            builder.OwnsMany(x => x.Permissions, navigatebuilder =>
            {
                navigatebuilder.HasKey(x => x.Id);
                navigatebuilder.Property(x => x.Access).HasMaxLength(500);
                navigatebuilder.WithOwner(x => x.Role).HasForeignKey(x=>x.RoleId);
            });



        }
    }
}
