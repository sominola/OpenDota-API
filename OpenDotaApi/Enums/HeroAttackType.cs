using System.Text.Json.Serialization;

namespace OpenDotaApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HeroAttackType
    {
        Melee,
        Ranged
    }
}