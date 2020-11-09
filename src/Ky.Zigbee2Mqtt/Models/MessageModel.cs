namespace Ky.Zigbee2Mqtt.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class MessageModel<T>
    {
        [JsonPropertyName("message")]
        public IReadOnlyList<T>? Messages { get; set; }
    }
}