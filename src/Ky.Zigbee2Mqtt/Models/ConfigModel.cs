namespace Ky.Zigbee2Mqtt.Models
{
    using System.Text.Json.Serialization;

    public class ConfigModel
    {
        [JsonPropertyName("commit")]
        public string Commit { get; set; } = string.Empty;

        [JsonPropertyName("coordinator")]
        public Config.CoordinatorModel Coordinator { get; set; } = new Config.CoordinatorModel();

        [JsonPropertyName("log_level")]
        public string LogLevel { get; set; } = string.Empty;

        [JsonPropertyName("network")]
        public Config.NetworkModel Network { get; set; } = new Config.NetworkModel();

        [JsonPropertyName("permit_join")]
        public bool PermitJoin { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; } = string.Empty;
    }
}