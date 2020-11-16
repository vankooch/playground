namespace Ky.Data.Logic.Profiles
{
    using AutoMapper;
    using Ky.Data.Enums;
    using Ky.Data.Model;
    using Ky.Zigbee2Mqtt.Models;

    public class ZigbeeDeviceToDeviceProfile : Profile
    {
        public ZigbeeDeviceToDeviceProfile()
        {
            this.CreateMap<DevicesModel, Device>()
                .ForMember(d => d.DateCode, opt => opt.MapFrom(s => s.DateCode))
                .ForMember(d => d.Description, opt => opt.MapFrom(s => s.Description))
                .ForMember(d => d.HardwareVersion, opt => opt.MapFrom(s => s.HardwareVersion))
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.IeeeAddr))
                .ForMember(d => d.IeeeAddr, opt => opt.MapFrom(s => s.IeeeAddr))
                .ForMember(d => d.LastSeen, opt => opt.MapFrom(s => s.LastSeen))
                .ForMember(d => d.ManufacturerId, opt => opt.MapFrom(s => s.ManufacturerId))
                .ForMember(d => d.ManufacturerName, opt => opt.MapFrom(s => s.ManufacturerName))
                .ForMember(d => d.Model, opt => opt.MapFrom(s => s.Model))
                .ForMember(d => d.ModelId, opt => opt.MapFrom(s => s.ModelId))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name))
                .ForMember(d => d.NetworkAddress, opt => opt.MapFrom(s => s.NetworkAddress))
                .ForMember(d => d.PowerSource, opt => opt.MapFrom(s => s.PowerSource))
                .ForMember(d => d.SoftwareBuildIs, opt => opt.MapFrom(s => s.SoftwareBuildIs))
                .ForMember(d => d.Type, opt => opt.MapFrom(s => DeviceType.Zigbee))
                .ForMember(d => d.Vendor, opt => opt.MapFrom(s => s.Vendor))
                .ForMember(d => d.ZigbeeType, opt => opt.MapFrom(s => s.Type))
                .ForMember(d => d.DeviceToZigbeeGroup, opt => opt.Ignore());
        }
    }
}