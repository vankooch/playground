namespace Ky.Data.Interfaces.Repositories
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Ky.Data.Model;

    public interface IDeviceRepository
    {
        Task<Device> Add(Device device, CancellationToken cancellationToken = default);

        Task DeleteById(IReadOnlyList<string> deviceIds, CancellationToken cancellationToken = default);

        Task DeleteById(string deviceId, CancellationToken cancellationToken = default);

        Task<IReadOnlyList<Device>> FindAll(CancellationToken cancellationToken = default);

        Task<Device?> FindById(string id, CancellationToken cancellationToken = default);

        Task<IReadOnlyList<Device>> FindById(IReadOnlyList<string> id, CancellationToken cancellationToken = default);

        Task<Device> Update(Device device, CancellationToken cancellationToken = default);

        Task Update(IReadOnlyList<Device> devices, CancellationToken cancellationToken = default);
    }
}