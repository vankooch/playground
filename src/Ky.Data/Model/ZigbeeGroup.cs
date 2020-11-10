namespace Ky.Data.Model
{
    using System.Collections.Generic;

    public class ZigbeeGroup
    {
        public ZigbeeGroup()
        {
            this.DeviceToZigbeeGroup = new HashSet<DeviceToZigbeeGroup>();
        }

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        #region Relations

        public virtual ICollection<DeviceToZigbeeGroup> DeviceToZigbeeGroup { get; set; }

        #endregion Relations
    }
}