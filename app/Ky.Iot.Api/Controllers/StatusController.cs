namespace Ky.Iot.Api.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;
    using Ky.Mqtt.Client.Extensions;
    using Ky.Mqtt.Client.Settings;
    using Microsoft.AspNetCore.Mvc;
    using MQTTnet.Client;
    using MQTTnet.Client.Connecting;

    /// <summary>
    /// Status and Test Controller
    /// Get information about the MQTT Client
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly IMqttClient _mqttClient;
        private readonly MqttClientSettings _mqttClientSettings;

        public StatusController(IMqttClient mqttClient, MqttClientSettings mqttClientSettings)
        {
            this._mqttClient = mqttClient;
            this._mqttClientSettings = mqttClientSettings;
        }

        /// <summary>
        /// Connect to MQTT Server
        /// </summary>
        /// <returns></returns>
        [HttpGet("Connect")]
        public async Task<ActionResult<MqttClientAuthenticateResult>> Connect(CancellationToken cancellationToken)
        {
            return await this._mqttClient
                .ConnectAsync(this._mqttClientSettings.GetMqttClientOptions(), cancellationToken)
                .ConfigureAwait(false);
        }

        /// <summary>
        /// Disconnect to MQTT Server
        /// </summary>
        /// <returns></returns>
        [HttpGet("Disconnect")]
        public async Task<ActionResult<bool>> Disconnect(CancellationToken cancellationToken)
        {
            await this._mqttClient
                .DisconnectAsync(null, cancellationToken)
                .ConfigureAwait(false);

            return true;
        }

        /// <summary>
        /// Check if MQTT client is connected to the server
        /// </summary>
        /// <returns></returns>
        [HttpGet("Status")]
        public ActionResult<bool> Status()
        {
            return this._mqttClient.IsConnected;
        }
    }
}