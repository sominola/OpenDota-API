using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Player
{
    using Model;
    using Model.WinLoss;
    using Model.RecentMatches;
    using Model.Matches;
    using Model.Peers;
    using Model.Pro;
    using Model.Totals;
    using Model.Histograms;
    using Model.WardMap;
    using Model.WordCloud;
    using Model.Ratings;
    using Model.Rankings;

    public class PlayerEndpoint : IPlayerEndpoint
    {
        private readonly RequestHandler _request;

        public PlayerEndpoint(RequestHandler requestHandler)
        {
            _request = requestHandler;
        }

        public async Task<Player> GetPlayerAsync(long playerId) =>
            await _request.GetResponseAsync<Player>($"players/{playerId}");

        public async Task<WinLoss> GetWinLossAsync(long playerId, PlayerParameters parameters = null) =>
            await _request.GetResponseAsync<WinLoss>($"players/{playerId}/wl" + parameters?.GetParameters());

        public async Task<List<RecentMatches>> GetRecentMatchesAsync(long playerId) =>
            await _request.GetResponseAsync<List<RecentMatches>>($"players/{playerId}/recentMatches");

        public async Task<List<Matches>> GetMatchesAsync(long playerId, PlayerParameters parameters = null) =>
            await _request.GetResponseAsync<List<Matches>>($"players/{playerId}/matches" + parameters?.GetParameters());

        public async Task<List<Model.Heroes.Heroes>> GetHeroesAsync(long playerId, PlayerParameters parameters = null) =>
            await _request.GetResponseAsync<List<Model.Heroes.Heroes>>($"players/{playerId}/heroes" + parameters?.GetParameters());

        public async Task<List<Peers>> GetPeersAsync(long playerId, PlayerParameters parameters = null) =>
            await _request.GetResponseAsync<List<Peers>>($"players/{playerId}/peers" + parameters?.GetParameters());

        public async Task<List<Pro>> GetProAsync(long playerId, PlayerParameters parameters = null) =>
            await _request.GetResponseAsync<List<Pro>>($"players/{playerId}/pros" + parameters?.GetParameters());

        public async Task<List<Totals>> GetTotalsAsync(long playerId, PlayerParameters parameters = null) =>
            await _request.GetResponseAsync<List<Totals>>($"players/{playerId}/totals" + parameters?.GetParameters());

        public async Task<List<Histograms>> GetHistogramsAsync(long playerId, string field, PlayerParameters parameters = null) =>
            await _request.GetResponseAsync<List<Histograms>>($"players/{playerId}/histograms/{field}" + parameters?.GetParameters());

        public async Task<List<WardMap>> GetWardMapAsync(long playerId, PlayerParameters parameters = null) =>
            await _request.GetResponseAsync<List<WardMap>>($"players/{playerId}/wardmap" + parameters?.GetParameters());

        public async Task<List<WordCloud>> GetWordCloudAsync(long playerId, PlayerParameters parameters = null) =>
            await _request.GetResponseAsync<List<WordCloud>>($"players/{playerId}/wordcloud" + parameters?.GetParameters());

        public async Task<List<Ratings>> GetRatingsAsync(long playerId) =>
            await _request.GetResponseAsync<List<Ratings>>($"players/{playerId}/ratings");

        public async Task<List<Rankings>> GetRankingsAsync(long playerId) =>
            await _request.GetResponseAsync<List<Rankings>>($"players/{playerId}/rankings");

        public async Task<bool> RefreshPlayerMatchHistory(long playerId)
        {
            var response = await _request.PostRequestAsync($"players/{playerId}/refresh");
            response.EnsureSuccessStatusCode();
            return true;
        }
    }
}