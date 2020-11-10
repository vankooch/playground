namespace Ky.Data.Model
{
    public class DeviceToZigbeeGroup
    {
        public Device? Device { get; set; }

        public string DeviceId { get; set; } = string.Empty;

        public ZigbeeGroup? ZigbeeGroup { get; set; }

        public int ZigbeeGroupId { get; set; }
    }
}