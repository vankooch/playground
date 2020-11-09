namespace Ky.Zigbee2Mqtt.Convert
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    public class DateTimeEpochConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            var data = reader.GetUInt64();
            return DateTimeOffset
                .FromUnixTimeMilliseconds(long.Parse(data.ToString()))
                .LocalDateTime;
        }

        public override void Write(
            Utf8JsonWriter writer,
            DateTime dateTimeValue,
            JsonSerializerOptions options) =>
                writer.WriteNumberValue(new DateTimeOffset(dateTimeValue).ToUnixTimeMilliseconds());
    }
}