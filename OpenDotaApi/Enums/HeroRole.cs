using System.Text.Json.Serialization;

namespace OpenDotaApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HeroRole
    {
        Carry,
        Disabler,
        Durable,
        Escape,
        Initiator,
        Jungler,
        Nuker,
        Pusher,
        Support
    };
}