using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Player.Model.Counts
{
    public class GameMode
    {
        [JsonPropertyName("games")]
        public long? Games { get; set; }

        [JsonPropertyName("win")]
        public long? Win { get; set; }
    }
}