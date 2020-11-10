namespace Ky.Zigbee2Mqtt.MqttHandler
{
    using System.Threading.Tasks;
    using MQTTnet;
    using MQTTnet.Client.Receiving;

    public class ZigbeeHandlerChain : IMqttApplicationMessageReceivedHandler
    {
        private readonly IMqttApplicationMessageReceivedHandler[] _list;

        public ZigbeeHandlerChain()
        {
            this._list = new IMqttApplicationMessageReceivedHandler[]
            {
                new BridgeLogHandler(),
            };
        }

        public async Task HandleApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs eventArgs)
        {
            try
            {
                if (this._list != null && this._list.Length > 0)
                {
                    for (var i = 0; i < this._list.Length; i++)
                    {
                        await this._list[i].HandleApplicationMessageReceivedAsync(eventArgs).ConfigureAwait(false);
                    }
                }
            }
            catch (System.Exception e)
            {
                throw;
            }

            return;
        }
    }
}