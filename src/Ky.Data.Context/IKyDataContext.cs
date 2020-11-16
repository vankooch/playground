namespace Ky.Data.Context
{
    using System.Threading;
    using System.Threading.Tasks;
    using Ky.Data.Model;
    using Microsoft.EntityFrameworkCore;

    public interface IKyDataContext
    {
        DbSet<Device> Devices { get; }

        DbSet<DeviceToZigbeeGroup> DevicesToZigbeeGroups { get; }

        DbSet<ZigbeeGroup> ZigbeeGroups { get; }

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}