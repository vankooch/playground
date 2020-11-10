namespace Ky.Data.Context
{
    using Ky.Data.Model;
    using Microsoft.EntityFrameworkCore;

    public interface IKyDataContext
    {
        DbSet<Device> Devices { get; }

        DbSet<DeviceToZigbeeGroup> DevicesToZigbeeGroups { get; }

        DbSet<ZigbeeGroup> ZigbeeGroups { get; }
    }
}