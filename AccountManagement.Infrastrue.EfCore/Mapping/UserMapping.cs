using AccountManagement.Domain.UserAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountManagement.Infrastrue.EfCore.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x=>x.UserName).HasMaxLength(255).IsRequired();
            builder.Property(x=>x.FullName).HasMaxLength(255).IsRequired();


            builder.HasOne(x=>x.Role).WithMany(x=>x.Users).HasForeignKey(x=>x.RoleId);

        }
    }
}
