namespace Ky.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Ky.Data.Context;
    using Ky.Data.Interfaces.Repositories;
    using Ky.Data.Model;
    using Microsoft.EntityFrameworkCore;

    public class DeviceRepository : IDeviceRepository
    {
        private readonly IKyDataContext _dataContext;

        public DeviceRepository(IKyDataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<Device> Add(Device device, CancellationToken cancellationToken = default)
        {
            if (device == null)
            {
                throw new ArgumentException(nameof(device));
            }

            _ = await this._dataContext
                  .Devices
                  .AddAsync(device, cancellationToken)
                  .ConfigureAwait(false);

            return device;
        }

        public async Task DeleteById(IReadOnlyList<string> deviceIds, CancellationToken cancellationToken = default)
        {
            if (deviceIds == null || !deviceIds.Any())
            {
                return;
            }

            var local = deviceIds.Where(e => !string.IsNullOrWhiteSpace(e));
            var entry = await this._dataContext
                .Devices
                .AsNoTracking()
                .Where(e => local.Contains(e.Id))
                .ToArrayAsync(cancellationToken)
                .ConfigureAwait(false);

            this._dataContext.Devices.RemoveRange(entry);
            await this._dataContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            return;
        }

        public async Task DeleteById(string deviceId, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(deviceId))
            {
                return;
            }

            var entry = await this._dataContext
                .Devices
                .AsNoTracking()
                .FirstAsync(e => e.Id == deviceId, cancellationToken)
                .ConfigureAwait(false);

            this._dataContext.Devices.Remove(entry);
            await this._dataContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            return;
        }

        public async Task<IReadOnlyList<Device>> FindAll(CancellationToken cancellationToken = default)
        {
            var db = await this._dataContext
                .Devices
                .AsNoTracking()
                .ToArrayAsync(cancellationToken)
                .ConfigureAwait(false);

            return db;
        }

        public async Task<Device?> FindById(string id, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return null;
            }

            var entry = await this._dataContext
                .Devices
                .AsNoTracking()
                .FirstAsync(e => e.Id == id, cancellationToken)
                .ConfigureAwait(false);

            return entry;
        }

        public async Task<IReadOnlyList<Device>> FindById(IReadOnlyList<string> id, CancellationToken cancellationToken = default)
        {
            if (id == null || !id.Any())
            {
                return Array.Empty<Device>();
            }

            var local = id.Where(e => !string.IsNullOrWhiteSpace(e));
            var entry = await this._dataContext
                .Devices
                .Where(e => local.Contains(e.Id))
                .AsNoTracking()
                .ToArrayAsync(cancellationToken)
                .ConfigureAwait(false);

            return entry;
        }

        public async Task<Device> Update(Device device, CancellationToken cancellationToken = default)
        {
            if (device == null)
            {
                throw new ArgumentException(nameof(device));
            }

            this._dataContext.Devices.Attach(device);
            this._dataContext.Entry(device).State = EntityState.Modified;

            await this._dataContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            return device;
        }

        public Task Update(IReadOnlyList<Device> devices, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}