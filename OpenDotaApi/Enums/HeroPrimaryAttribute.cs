using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HeroPrimaryAttribute
    {
        Agi,
        Int,
        Str
    };
}