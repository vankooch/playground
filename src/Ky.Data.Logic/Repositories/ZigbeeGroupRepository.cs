﻿namespace Ky.Data.Logic.Repositories
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Ky.Data.Context;
    using Ky.Data.Interfaces.Repositories;
    using Ky.Data.Model;

    public class ZigbeeGroupRepository : IZigbeeGroupRepository
    {
        private readonly IKyDataContext _dataContext;

        public ZigbeeGroupRepository(IKyDataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public Task DeleteById(int id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<ZigbeeGroup> GetById(int id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<IReadOnlyList<Device>> GetDevicesByGroupId(int id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(ZigbeeGroup device, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}