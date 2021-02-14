using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Scenarios.Model
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