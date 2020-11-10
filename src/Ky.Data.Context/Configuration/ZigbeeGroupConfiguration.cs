namespace Ky.Data.Context.Configuration
{
    using Ky.Data.Model;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ZigbeeGroupConfiguration : IEntityTypeConfiguration<ZigbeeGroup>
    {
        public void Configure(EntityTypeBuilder<ZigbeeGroup> builder)
        {
            if (builder == null)
            {
                return;
            }

            builder.ToTable(KyDataContextConfiguration.TABLE_ZIGBEE_GROUP, KyDataContextConfiguration.SCHEMA_NAME);

            builder
                .HasKey(t => t.Id);
        }
    }
}