using System.Collections.Generic;
using System.Threading;
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

        public async Task<List<Team>> GetTeamsAsync(CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<List<Team>>("teams", null, token);

        public async Task<Team> GetTeamByIdAsync(long teamId, CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<Team>($"teams/{teamId}", null,token);

        public async Task<List<Match>> GetMatchesAsync(long teamId, CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<List<Match>>($"teams/{teamId}/matches", null,token);

        public async Task<List<Player>> GetPlayersAsync(long teamId, CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<List<Player>>($"teams/{teamId}/players", null,token);

        public async Task<List<Hero>> GetHeroesAsync(long teamId, CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<List<Hero>>($"teams/{teamId}/heroes", null, token);
    }
}