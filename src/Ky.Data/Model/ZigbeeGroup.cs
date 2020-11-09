namespace Ky.Data.Model
{
    using System.Collections.Generic;

    public class ZigbeeGroup
    {
        public ZigbeeGroup()
        {
            this.Devices = new HashSet<Device>();
        }

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        #region Relations

        public virtual ICollection<Device> Devices { get; set; }

        #endregion Relations
    }
}