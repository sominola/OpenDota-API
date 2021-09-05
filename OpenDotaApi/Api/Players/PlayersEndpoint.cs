using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Players
{
    using Model;
    using Model.Histograms;
    using Model.Peers;
    using Model.Pro;
    using Model.Ratings;
    using Model.RecentMatches;
    using Model.Totals;
    using Model.WardMap;
    using Model.WinLoss;
    using Model.WordCloud;

    public class PlayersEndpoint : IPlayersEndpoint
    {
        private readonly JsonFormatter _formatter;
        private readonly RequestHandler _request;

        public PlayersEndpoint(JsonFormatter formatter, RequestHandler request)
        {
            _formatter = formatter;
            _request = request;
        }

        public async Task<Player> GetPlayerAsync(long playerId) =>
            await _formatter.DeserializeAsync<Player>($"players/{playerId}");

        public async Task<WinLoss> GetWinLossAsync(long playerId, PlayerParameters parameters = null) =>
            await _formatter.DeserializeAsync<WinLoss>($"players/{playerId}/wl", parameters?.GetParameters());

        public async Task<List<RecentMatches>> GetRecentMatchesAsync(long playerId) =>
            await _formatter.DeserializeAsync<List<RecentMatches>>($"players/{playerId}/recentMatches");

        public async Task<List<Model.Matches.Matches>> GetMatchesAsync(long playerId,
            PlayerParameters parameters = null) =>
            await _formatter.DeserializeAsync<List<Model.Matches.Matches>>($"players/{playerId}/matches",
                parameters?.GetParameters());

        public async Task<List<Model.Heroes.Heroes>>
            GetHeroesAsync(long playerId, PlayerParameters parameters = null) =>
            await _formatter.DeserializeAsync<List<Model.Heroes.Heroes>>($"players/{playerId}/heroes",
                parameters?.GetParameters());

        public async Task<List<Peers>> GetPeersAsync(long playerId, PlayerParameters parameters = null) =>
            await _formatter.DeserializeAsync<List<Peers>>($"players/{playerId}/peers", parameters?.GetParameters());

        public async Task<List<Pro>> GetProAsync(long playerId, PlayerParameters parameters = null) =>
            await _formatter.DeserializeAsync<List<Pro>>($"players/{playerId}/pros", parameters?.GetParameters());

        public async Task<List<Totals>> GetTotalsAsync(long playerId, PlayerParameters parameters = null) =>
            await _formatter.DeserializeAsync<List<Totals>>($"players/{playerId}/totals", parameters?.GetParameters());

        public async Task<List<Histograms>> GetHistogramsAsync(long playerId, string field,
            PlayerParameters parameters = null) =>
            await _formatter.DeserializeAsync<List<Histograms>>($"players/{playerId}/histograms/{field}",
                parameters?.GetParameters());

        public async Task<WardMap> GetWardMapAsync(long playerId, PlayerParameters parameters = null) =>
            await _formatter.DeserializeAsync<WardMap>($"players/{playerId}/wardmap", parameters?.GetParameters());

        public async Task<WordCloud> GetWordCloudAsync(long playerId, PlayerParameters parameters = null) =>
            await _formatter.DeserializeAsync<WordCloud>($"players/{playerId}/wordcloud", parameters?.GetParameters());

        public async Task<List<Ratings>> GetRatingsAsync(long playerId) =>
            await _formatter.DeserializeAsync<List<Ratings>>($"players/{playerId}/ratings");

        public async Task<List<Model.Rankings.Rankings>> GetRankingsAsync(long playerId) =>
            await _formatter.DeserializeAsync<List<Model.Rankings.Rankings>>($"players/{playerId}/rankings");

        public async Task<bool> RefreshPlayerMatchHistoryAsync(long playerId)
        {
            await _request.PostRequestAsync($"players/{playerId}/refresh");
            return true;
        }
    }
}