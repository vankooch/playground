namespace Ky.Zigbee2Mqtt.Interfaces
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Ky.Zigbee2Mqtt.Models;

    public interface IZigbeeDeviceRepository
    {
        Task<IReadOnlyList<DevicesModel>> Get(CancellationToken cancellationToken = default);

        Task Update(IReadOnlyList<DevicesModel> devices, CancellationToken cancellationToken = default);
    }
}