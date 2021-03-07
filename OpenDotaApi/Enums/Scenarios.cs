using System.Text.Json.Serialization;

namespace OpenDotaApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Scenarios
    {
        CourierKill,
        FirstBlood,
        NegChat1Min,
        PosChat1Min
    }
}