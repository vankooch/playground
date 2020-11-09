namespace Ky.Zigbee2Mqtt.Models.Config
{
    using System.Text.Json.Serialization;

    public class NetworkModel
    {
        [JsonPropertyName("channel")]
        public int Channel { get; set; }

        [JsonPropertyName("extendedPanID")]
        public string ExtendedPanId { get; set; } = string.Empty;

        [JsonPropertyName("panID")]
        public int PanId { get; set; }
    }
}