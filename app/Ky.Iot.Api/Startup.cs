namespace Ky.Iot.Api
{
    using System.Threading;
    using System.Threading.Tasks;
    using Ky.Mqtt.Client.Extensions;
    using Ky.Mqtt.Client.Settings;
    using Ky.Zigbee2Mqtt.MqttHandler;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using MQTTnet;
    using MQTTnet.Client;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables();

            this.Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Read MQTT Client Settings
            var mqttClientSettings = new MqttClientSettings();
            this.Configuration.Bind("MQTT:Client", mqttClientSettings);
            services.AddSingleton(mqttClientSettings);

            // Create client object
            var factory = new MqttFactory();
            var mqttClient = factory.CreateMqttClient();
            mqttClient.UseApplicationMessageReceivedHandler(new ZigbeeHandlerChain());

            // Try to connect
            Task.Run(() => mqttClient
               .ConnectAsync(mqttClientSettings.GetMqttClientOptions(), CancellationToken.None)
               .ConfigureAwait(false));

            services.AddSingleton(mqttClient);
        }
    }
}