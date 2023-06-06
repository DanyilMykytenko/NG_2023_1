using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntityConfiguration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(u => u.Id)
                .IsRequired().ValueGeneratedOnAdd();
        }
    }
}
