using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Api.Heroes.Model;
using OpenDotaApi.Api.Heroes.Model.Duration;
using OpenDotaApi.Api.Heroes.Model.ItemPopularity;
using OpenDotaApi.Api.Heroes.Model.Matchup;
using OpenDotaApi.Utilities;


namespace OpenDotaApi.Api.Heroes
{
    public class HeroesEndpoint : IHeroesEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public HeroesEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<Hero>> GetDataAsync() =>
            await _formatter.DeserializeAsync<List<Hero>>("heroes");

        public async Task<List<Model.Match.Match>> GetRecentMatchesAsync(int heroId) =>
            await _formatter.DeserializeAsync<List<Model.Match.Match>>($"heroes/{heroId}/matches");

        public async Task<List<Matchup>> GetMatchUpsAsync(int heroId) =>
            await _formatter.DeserializeAsync<List<Matchup>>($"heroes/{heroId}/matchups");

        public async Task<List<Duration>> GetDurationsAsync(int heroId) =>
            await _formatter.DeserializeAsync<List<Duration>>($"heroes/{heroId}/durations");

        public async Task<List<Model.Player.Player>> GetPlayersAsync(int heroId) =>
            await _formatter.DeserializeAsync<List<Model.Player.Player>>($"heroes/{heroId}/players");

        public async Task<ItemPopularity> GetItemPopularityAsync(int heroId) =>
            await _formatter.DeserializeAsync<ItemPopularity>($"heroes/{heroId}/itemPopularity");
    }
}