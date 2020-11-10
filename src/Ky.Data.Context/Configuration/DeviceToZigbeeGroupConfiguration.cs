namespace Ky.Data.Context.Configuration
{
    using Ky.Data.Model;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DeviceToZigbeeGroupConfiguration : IEntityTypeConfiguration<DeviceToZigbeeGroup>
    {
        public void Configure(EntityTypeBuilder<DeviceToZigbeeGroup> builder)
        {
            if (builder == null)
            {
                return;
            }

            builder.ToTable(KyDataContextConfiguration.TBALE_DEVICE_TO_ZIGBEE_GROUP, KyDataContextConfiguration.SCHEMA_NAME);

            builder
                .HasKey(t => new { t.ZigbeeGroupId, t.DeviceId });

            builder
                .HasOne(e => e.Device)
                .WithMany(r => r.DeviceToZigbeeGroup)
                .HasForeignKey(e => e.DeviceId);

            builder
                .HasOne(e => e.ZigbeeGroup)
                .WithMany(r => r.DeviceToZigbeeGroup)
                .HasForeignKey(e => e.ZigbeeGroupId);
        }
    }
}