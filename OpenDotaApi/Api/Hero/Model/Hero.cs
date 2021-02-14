using System.Collections.Generic;
using System.Text.Json.Serialization;
using OpenDotaApi.Enums;

namespace OpenDotaApi.Api.Hero.Model
{
    public class Hero
    {
        [JsonPropertyName("id")]
        public long? Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("localized_name")]
        public string LocalizedName { get; set; }

        [JsonPropertyName("primary_attr")]
        public HeroPrimaryAttribute? PrimaryAttr { get; set; }

        [JsonPropertyName("attack_type")]
        public HeroAttackType? AttackType { get; set; }

        [JsonPropertyName("roles")]
        public List<HeroRole> Roles { get; set; }

        [JsonPropertyName("legs")]
        public long? Legs { get; set; }
    }
}