using Microsoft.EntityFrameworkCore;
using MobileDevicesManagement.Data.DBSets;
using MobileDevicesManagement.Data.EntityConfigurations;

namespace MobileDevicesManagement.Data.DBContexts
{
    public class MobileDevicesDbContext : DbContext
    {

        public MobileDevicesDbContext(DbContextOptions<MobileDevicesDbContext> options) :base(options)
        {

        }
        public DbSet<MobileDevice> MobileDevices { get; set; }
        public DbSet<MobileDeviceType> MobileDeviceType { get; set; }

        public DbSet<MobileDeviceModel> MobileDeviceModels { get; set; }
        public DbSet<MobileDeviceMake> MobileDeviceMakes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MobileDeviceEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MobileDeviceTypeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MobileDeviceModelEntityConfiguration());
            modelBuilder.ApplyConfiguration(new MobileDeviceMakeEntityConfiguration());

        }
    }
}
