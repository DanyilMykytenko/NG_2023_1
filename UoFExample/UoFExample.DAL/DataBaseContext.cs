using Microsoft.EntityFrameworkCore;
using UoFExample.DAL.Configs;
using UoFExample.DAL.Entities;

namespace UoFExample.DAL;

public class DataBaseContext : DbContext
{
    public virtual DbSet<Game> Games { get; set; }
    public virtual DbSet<Genre> Genres { get; set; }
    
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new GameConfig());

        base.OnModelCreating(builder);
    }
}