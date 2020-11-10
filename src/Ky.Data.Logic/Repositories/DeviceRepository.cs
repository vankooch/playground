namespace Ky.Data.Repositories
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Ky.Data.Context;
    using Ky.Data.Interfaces.Repositories;
    using Ky.Data.Model;

    public class DeviceRepository : IDeviceRepository
    {
        private readonly IKyDataContext _dataContext;

        public DeviceRepository(IKyDataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public Task DeleteById(IReadOnlyList<string> deviceIds, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteById(string deviceId, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<Device>> GetAll(CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<Device> GetById(string id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Device device, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(IReadOnlyList<Device> devices, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}