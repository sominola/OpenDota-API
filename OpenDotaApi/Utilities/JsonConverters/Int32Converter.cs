using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Utilities.JsonConverters
{
    public class Int32Converter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (int.TryParse(stringValue, out var value))
                    {
                        return value;
                    }

                    break;
                }
                case JsonTokenType.Number:
                    return reader.GetInt32();
            }

            throw new JsonException();
        }
 
        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value);
        }
    }
}