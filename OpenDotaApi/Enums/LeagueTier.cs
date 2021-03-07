using System.Text.Json.Serialization;

namespace OpenDotaApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LeagueTier
    {
        Amateur,
        Excluded,
        Premium,
        Professional
    }
}