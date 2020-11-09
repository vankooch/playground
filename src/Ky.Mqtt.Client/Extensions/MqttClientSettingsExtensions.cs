namespace Ky.Mqtt.Client.Extensions
{
    using System;
    using Ky.Mqtt.Client.Settings;
    using MQTTnet.Client.Options;

    public static class MqttClientSettingsExtensions
    {
        public static IMqttClientOptions GetMqttClientOptions(this MqttClientSettings me)
        {
            if (me == null)
            {
                throw new ArgumentNullException(nameof(me));
            }

            // Create TCP based options using the builder.
            var options = new MqttClientOptionsBuilder()
                .WithTcpServer(me.Server);

            if (me.TLS)
            {
                options.WithTls();
            }

            if (!string.IsNullOrWhiteSpace(me.UserName))
            {
                options.WithCredentials(me.UserName.Trim(), me.Password?.Trim());
            }

            return options
               .WithCleanSession()
               .Build();
        }
    }
}