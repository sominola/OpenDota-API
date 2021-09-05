using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Teams
{
    using Model;
    using Model.Match;
    using Model.Player;
    using Model.Hero;

    public class TeamsEndpoint : ITeamsEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public TeamsEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<Team>> GetTeamsAsync() =>
            await _formatter.DeserializeAsync<List<Team>>("teams");

        public async Task<Team> GetTeamByIdAsync(long teamId) =>
            await _formatter.DeserializeAsync<Team>($"teams/{teamId}");

        public async Task<List<Match>> GetMatchesAsync(long teamId) =>
            await _formatter.DeserializeAsync<List<Match>>($"teams/{teamId}/matches");

        public async Task<List<Player>> GetPlayersAsync(long teamId) =>
            await _formatter.DeserializeAsync<List<Player>>($"teams/{teamId}/players");

        public async Task<List<Hero>> GetHeroesAsync(long teamId) =>
            await _formatter.DeserializeAsync<List<Hero>>($"teams/{teamId}/heroes");
    }
}