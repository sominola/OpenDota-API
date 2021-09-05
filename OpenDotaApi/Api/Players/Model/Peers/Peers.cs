using System;
using System.Text.Json.Serialization;

namespace OpenDotaApi.Api.Players.Model.Peers
{
    public class Peers
    {
        [JsonPropertyName("account_id")]
        public int? AccountId { get; set; }

        [JsonPropertyName("last_played")]
        public long? LastPlayed { get; set; }

        [JsonPropertyName("win")]
        public int? Win { get; set; }

        [JsonPropertyName("games")]
        public int? Games { get; set; }

        [JsonPropertyName("with_win")]
        public int? WithWin { get; set; }

        [JsonPropertyName("with_games")]
        public int? WithGames { get; set; }

        [JsonPropertyName("against_win")]
        public int? AgainstWin { get; set; }

        [JsonPropertyName("against_games")]
        public int? AgainstGames { get; set; }

        [JsonPropertyName("with_gpm_sum")]
        public int? WithGpmSum { get; set; }

        [JsonPropertyName("with_xpm_sum")]
        public int? WithXpmSum { get; set; }

        [JsonPropertyName("personaname")]
        public string PersonaName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("is_contributor")]
        public bool? IsContributor { get; set; }

        [JsonPropertyName("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonPropertyName("avatar")]
        public Uri Avatar { get; set; }

        [JsonPropertyName("avatarfull")]
        public Uri AvatarFull { get; set; }
    }
}