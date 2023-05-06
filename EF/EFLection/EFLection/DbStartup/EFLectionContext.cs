using EFLection.Entities;
using EFLection.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace EFLection.DbStartup
{
    public class EFLectionContext : DbContext
    {
        public EFLectionContext(DbContextOptions<EFLectionContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Manager> Managers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new ManagerConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
