namespace Ky.Iot.Api.Controllers
{
    using System.Threading.Tasks;
    using Ky.Mqtt.Client.Settings;
    using Ky.Mqtt.Client.Zigbee2Mqtt;
    using Microsoft.AspNetCore.Mvc;
    using MQTTnet;
    using MQTTnet.Client;
    using MQTTnet.Client.Subscribing;

    /// <summary>
    /// Zigbee2MQTT Controller
    /// This is used to get informations from the Zigbee2MQTT system
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ZigbeeController : ControllerBase
    {
        private readonly IMqttClient _mqttClient;
        private readonly MqttClientSettings _mqttClientSettings;

        public ZigbeeController(IMqttClient mqttClient, MqttClientSettings mqttClientSettings)
        {
            this._mqttClient = mqttClient;
            this._mqttClientSettings = mqttClientSettings;
        }

        /// <summary>
        /// Connect to MQTT Server
        /// </summary>
        /// <returns></returns>
        [HttpGet("Subscribe")]
        public async Task<ActionResult<MqttClientSubscribeResult>> Subscribe()
        {
            var options = new MqttTopicFilterBuilder()
                .WithTopic(BridgeLogHandler.TOPIC)
                .Build();

            var result = await this._mqttClient
                .SubscribeAsync(options)
                .ConfigureAwait(false);

            return result;
        }
    }
}
