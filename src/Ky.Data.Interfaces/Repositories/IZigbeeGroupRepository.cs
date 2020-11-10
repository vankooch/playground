namespace Ky.Data.Interfaces.Repositories
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Ky.Data.Model;

    public interface IZigbeeGroupRepository
    {
        Task DeleteById(int id, CancellationToken cancellationToken = default);

        Task<ZigbeeGroup> GetById(int id, CancellationToken cancellationToken = default);

        Task<IReadOnlyList<Device>> GetDevicesByGroupId(int id, CancellationToken cancellationToken = default);

        Task Update(ZigbeeGroup device, CancellationToken cancellationToken = default);
    }
}