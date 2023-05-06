using EFLection.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFLection.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasIndex(x => x.Id);
            builder.Property(x => x.Id).IsRequired();

            builder.Property(x => x.FullName).IsRequired();
            builder.Property(x => x.FullName).HasMaxLength(100);

            builder.Property(x => x.Salary).IsRequired();

            builder
                .HasOne(x => x.Account)
                .WithOne(x => x.User)
                .HasForeignKey<Account>(x => x.Id)
                .HasPrincipalKey<User>(x => x.Id);

            builder
                .HasMany(x => x.Teams)
                .WithMany(x => x.Users);

            builder
                .HasOne(x => x.Manager)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.ManagerId)
                .HasPrincipalKey(x => x.Id);
        }
    }
}
