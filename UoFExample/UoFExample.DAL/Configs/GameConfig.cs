using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UoFExample.DAL.Entities;

namespace UoFExample.DAL.Configs;

public class GameConfig : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.Property(x => x.Name).HasColumnType("nvarchar(40)");

        builder
            .HasOne(x => x.Genre)
            .WithMany(x => x.Games)
            .HasForeignKey(x => x.GenreId).IsRequired(false)
            .HasPrincipalKey(x => x.Id)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}