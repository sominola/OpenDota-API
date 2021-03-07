using System.Text.Json.Serialization;

namespace OpenDotaApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HeroLaneRole
    {
        Safe = 1,
        Mid = 2,
        Offlane = 3,
        Jungle = 4
    }
}