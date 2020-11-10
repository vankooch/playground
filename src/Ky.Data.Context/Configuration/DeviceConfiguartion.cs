namespace Ky.Data.Context.Configuration
{
    using Ky.Data.Model;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class DeviceConfiguartion : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            if (builder == null)
            {
                return;
            }

            builder.ToTable(KyDataContextConfiguration.TABLE_DEVICE, KyDataContextConfiguration.SCHEMA_NAME);

            builder
                .HasKey(t => t.Id);
        }
    }
}