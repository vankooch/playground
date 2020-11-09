namespace Ky.Data.Repositories
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Ky.Data.Model;

    public interface IDeviceRepository
    {
        Task DeleteById(IReadOnlyList<string> deviceIds, CancellationToken cancellationToken = default);

        Task DeleteById(string deviceId, CancellationToken cancellationToken = default);

        Task<IReadOnlyList<Device>> GetAll(CancellationToken cancellationToken = default);

        Task<IReadOnlyList<Device>> GetByid(string id, CancellationToken cancellationToken = default);

        Task Update(Device device, CancellationToken cancellationToken = default);

        Task Update(IReadOnlyList<Device> devices, CancellationToken cancellationToken = default);
    }
}