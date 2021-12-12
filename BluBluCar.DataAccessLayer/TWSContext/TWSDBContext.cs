using Microsoft.EntityFrameworkCore;
using TWS.DataAccessLayer.Configuration;
using TWS.DataAccessLayer.Entities;

namespace TWS.DataAccessLayer.TWSContext
{
    public class TWSDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<DriverAccount> DriverAccounts { get; set; }
        public DbSet<TravelerAccount> TravelerAccounts { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Trip> Trips { get; set; }

        public TWSDBContext(DbContextOptions<TWSDBContext> options)
              : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new DriverAccountConfig());
            modelBuilder.ApplyConfiguration(new TravelerAccountConfig());
            modelBuilder.ApplyConfiguration(new TransportConfig());
            modelBuilder.ApplyConfiguration(new TripConfig());
        }

    }
}
