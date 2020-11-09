namespace Ky.Zigbee2Mqtt.Models
{
    using System;
    using System.Text.Json.Serialization;
    using Ky.Zigbee2Mqtt.Convert;

    public class DevicesModel
    {
        [JsonPropertyName("dateCode")]
        public string DateCode { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("hardwareVersion")]
        public int HardwareVersion { get; set; }

        [JsonPropertyName("ieeeAddr")]
        public string IeeeAddr { get; set; } = string.Empty;

        [JsonPropertyName("lastSeen")]
        [JsonConverter(typeof(DateTimeEpochConverter))]
        public DateTime LastSeen { get; set; }

        [JsonPropertyName("manufacturerID")]
        public int ManufacturerId { get; set; }

        [JsonPropertyName("manufacturerName")]
        public string? ManufacturerName { get; set; }

        [JsonPropertyName("model")]
        public string? Model { get; set; }

        [JsonPropertyName("modelID")]
        public string? ModelID { get; set; }

        [JsonPropertyName("friendly_name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("networkAddress")]
        public int NetworkAddress { get; set; }

        [JsonPropertyName("powerSource")]
        public string? PowerSource { get; set; }

        [JsonPropertyName("softwareBuildID")]
        public string SoftwareBuildIs { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("vendor")]
        public string? Vendor { get; set; }
    }
}