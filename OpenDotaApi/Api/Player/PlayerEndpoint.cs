using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Api.Player.Model.Totals;

namespace OpenDotaApi.Api.Player
{
    using Model;
    using Model.WinLoss;
    using Model.RecentMatches;
    using Model.Matches;
    using Model.Heroes;
    using Model.Peers;
    using Model.Pros;
    public class PlayerEndpoint : IPlayerEndpoint
    {
        private readonly RequestHandler _request;

        public PlayerEndpoint(RequestHandler requestHandler)
        {
            this._request = requestHandler;
        }

        public async Task<Player> GetPlayerAsync(long playerId)
        {
            return await _request.GetResponseAsync<Player>($"players/{playerId}");
        }

        public async Task<WinLoss> GetWinLossAsync(long playerId, PlayerParameters parameters = null)
        {
            return await _request.GetResponseAsync<WinLoss>($"players/{playerId}/wl" + parameters?.GetParameters());
        }

        public async Task<List<RecentMatches>> GetRecentMatchesAsync(long playerId)
        {
            return await _request.GetResponseAsync<List<RecentMatches>>($"players/{playerId}/recentMatches");
        }

        public async Task<List<Matches>> GetMatchesAsync(long playerId, PlayerParameters parameters = null)
        {
            return await _request.GetResponseAsync<List<Matches>>($"players/{playerId}/matches"+parameters?.GetParameters());
        }

        public async Task<List<Model.Heroes.Heroes>> GetHeroesAsync(long playerId, PlayerParameters parameters = null)
        {
            return await _request.GetResponseAsync<List<Model.Heroes.Heroes>>($"players/{playerId}/heroes"+parameters?.GetParameters());
        }

        public async Task<List<Peers>> GetPeersAsync(long playerId, PlayerParameters parameters = null)
        {
            return await _request.GetResponseAsync<List<Peers>>($"players/{playerId}/peers"+parameters?.GetParameters());
        }

        public async Task<List<Pros>> GetProsAsync(long playerId, PlayerParameters parameters = null)
        {
            return await _request.GetResponseAsync<List<Pros>>($"players/{playerId}/pros"+parameters?.GetParameters());
        }

        public async Task<List<Totals>> GetTotalsAsync(long playerId, PlayerParameters parameters = null)
        {
            return await _request.GetResponseAsync<List<Totals>>($"players/{playerId}/totals"+parameters?.GetParameters());
        }
        
        
    }
}