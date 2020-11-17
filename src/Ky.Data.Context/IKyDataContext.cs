namespace Ky.Data.Context
{
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using System.Threading.Tasks;
    using Ky.Data.Model;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;

    public interface IKyDataContext
    {
        DbSet<Device> Devices { get; }

        DbSet<DeviceToZigbeeGroup> DevicesToZigbeeGroups { get; }

        DbSet<ZigbeeGroup> ZigbeeGroups { get; }

        EntityEntry Entry([NotNull] object entity);

        EntityEntry<TEntity> Entry<TEntity>([NotNull] TEntity entity) where TEntity : class;

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}