using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Hero
{
    using Model;
    using Model.Match;
    using Model.Matchup;
    using Model.Duration;
    using Model.Player;
    using Model.ItemPopularity;
    public class HeroEndpoint : IHeroEndpoint
    {
        private readonly RequestHandler _request;

        public HeroEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<Hero>> GetDataAsync() =>
            await _request.GetResponseAsync<List<Hero>>("heroes");

        public async Task<List<Match>> GetRecentMatchesAsync(int heroId) =>
            await _request.GetResponseAsync<List<Match>>($"heroes/{heroId}/matches");

        public async Task<List<Matchup>> GetMatchupsAsync(int heroId) =>
            await _request.GetResponseAsync<List<Matchup>>($"heroes/{heroId}/matchups");

        public async Task<List<Duration>> GetDurationsAsync(int heroId) =>
            await _request.GetResponseAsync<List<Duration>>($"heroes/{heroId}/durations");

        public async Task<List<Player>> GetPlayersAsync(int heroId) =>
            await _request.GetResponseAsync<List<Player>>($"heroes/{heroId}/players");

        public async Task<ItemPopularity> GetItemPopularity(int heroId) =>
            await _request.GetResponseAsync<ItemPopularity>($"heroes/{heroId}/itemPopularity");
    }
}