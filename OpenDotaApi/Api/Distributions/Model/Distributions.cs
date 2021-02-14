using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Distributions.Model
{
    public class Distributions
    {
        [JsonPropertyName("ranks")]
        public Mmr Ranks { get; set; }

        [JsonPropertyName("mmr")]
        public Mmr Mmr { get; set; }

        [JsonPropertyName("country_mmr")]
        public CountryMmr CountryMmr { get; set; }
    }
}