using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Players.Model.WordCloud
{
    public class WordCloud
    {
        [JsonPropertyName("my_word_counts")]
        public Dictionary<string, long> MyWordCounts { get; set; }

        [JsonPropertyName("all_word_counts")]
        public Dictionary<string, long> AllWordCounts { get; set; }
    }
}