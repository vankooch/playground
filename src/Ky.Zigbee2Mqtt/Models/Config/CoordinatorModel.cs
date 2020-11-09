namespace Ky.Zigbee2Mqtt.Models.Config
{
    using System.Text.Json.Serialization;

    public class CoordinatorModel
    {
        [JsonPropertyName("meta")]
        public CoordinatorMetaModel Meta { get; set; } = new CoordinatorMetaModel();

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;
    }
}