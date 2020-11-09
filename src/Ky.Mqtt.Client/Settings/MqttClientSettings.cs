namespace Ky.Mqtt.Client.Settings
{
    public class MqttClientSettings
    {
        /// <summary>
        /// MQQT Client Id
        /// </summary>
        public string? ClientId { get; set; }

        /// <summary>
        /// MQQT User Password / API Key
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// MQQT Server
        /// </summary>
        public string Server { get; set; } = string.Empty;

        /// <summary>
        /// Use TLS connection
        /// </summary>
        public bool TLS { get; set; }

        /// <summary>
        /// MQQT User Name
        /// </summary>
        public string? UserName { get; set; }
    }
}
