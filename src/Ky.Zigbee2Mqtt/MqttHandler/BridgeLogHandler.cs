namespace Ky.Zigbee2Mqtt.MqttHandler
{
    using System.Text.Json;
    using System.Threading.Tasks;
    using Ky.Zigbee2Mqtt.Models;
    using MQTTnet;
    using MQTTnet.Client.Receiving;

    public class BridgeLogHandler : IMqttApplicationMessageReceivedHandler
    {
        public const string TOPIC = "zigbee2mqtt/bridge/log";

        public Task HandleApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs eventArgs)
        {
            if (eventArgs == null || eventArgs.ApplicationMessage.Topic != TOPIC)
            {
                return Task.CompletedTask;
            }

            var json = eventArgs.ApplicationMessage.ConvertPayloadToString();
            var model = JsonSerializer.Deserialize<MessageModel<DevicesModel>>(json);

            return Task.CompletedTask;
        }
    }
}