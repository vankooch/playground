namespace Ky.Zigbee2Mqtt.Models.Config
{
    using System.Text.Json.Serialization;

    public class CoordinatorMetaModel
    {
        [JsonPropertyName("maintrel")]
        public int Maintrel { get; set; }

        [JsonPropertyName("majorrel")]
        public int Majorrel { get; set; }

        [JsonPropertyName("minorrel")]
        public int Minorrel { get; set; }

        [JsonPropertyName("product")]
        public int Product { get; set; }

        [JsonPropertyName("revision")]
        public string Revision { get; set; } = string.Empty;

        [JsonPropertyName("transportrev")]
        public int Transportrev { get; set; }
    }
}