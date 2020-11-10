namespace Ky.Data.Context
{
    using Ky.Data.Model;
    using Microsoft.EntityFrameworkCore;

    public class KyDataContext : DbContext, IKyDataContext
    {
        public virtual DbSet<Device> Devices { get; private set; }

        public virtual DbSet<DeviceToZigbeeGroup> DevicesToZigbeeGroups { get; private set; }

        public virtual DbSet<ZigbeeGroup> ZigbeeGroups { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
            {
                return;
            }

            base.OnModelCreating(modelBuilder);

            // Main
            _ = modelBuilder.ApplyConfigurationsFromAssembly(typeof(KyDataContext).Assembly);
        }
    }
}