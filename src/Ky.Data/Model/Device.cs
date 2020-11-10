namespace Ky.Data.Model
{
    using System;
    using System.Collections.Generic;
    using Ky.Data.Enums;

    public class Device
    {
        public Device()
        {
            this.DeviceToZigbeeGroup = new HashSet<DeviceToZigbeeGroup>();
        }

        public string DateCode { get; set; } = string.Empty;

        public string? Description { get; set; }

        public int HardwareVersion { get; set; }

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string IeeeAddr { get; set; } = string.Empty;

        public DateTime LastSeen { get; set; }

        public int ManufacturerId { get; set; }

        public string? ManufacturerName { get; set; }

        public string? Model { get; set; }

        public string? ModelID { get; set; }

        public string Name { get; set; } = string.Empty;

        public int NetworkAddress { get; set; }

        public string? PowerSource { get; set; }

        public string SoftwareBuildIs { get; set; } = string.Empty;

        public DeviceType Type { get; set; } = DeviceType.Unknows;

        public string? Vendor { get; set; }

        public string ZigbeeType { get; set; } = string.Empty;

        #region Relations

        public virtual ICollection<DeviceToZigbeeGroup> DeviceToZigbeeGroup { get; set; }

        #endregion Relations
    }
}