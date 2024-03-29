using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Utilities.JsonConverters
{
    public class DateTimeConverter : JsonConverter<DateTime>
    {
        private static readonly DateTime Epoch = new(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                {
                    if (long.TryParse(reader.GetString(), out var value))
                    {
                        return DateTimeOffset.FromUnixTimeSeconds(value).DateTime;
                    }
                    break;
                }
              
            }

            return DateTimeOffset.FromUnixTimeSeconds(reader.GetInt64()).DateTime;
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue((value - Epoch).TotalMilliseconds + "000");
        }
    }
}