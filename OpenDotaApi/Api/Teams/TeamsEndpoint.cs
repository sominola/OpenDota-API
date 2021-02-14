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
        private readonly RequestHandler _request;

        public TeamsEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<Team>> GetTeamsAsync() =>
            await _request.GetResponseAsync<List<Team>>("teams");

        public async Task<Team> GetTeamByIdAsync(long teamId) =>
            await _request.GetResponseAsync<Team>($"teams/{teamId}");

        public async Task<List<Match>> GetMatchesAsync(long teamId) =>
            await _request.GetResponseAsync<List<Match>>($"teams/{teamId}/matches");

        public async Task<List<Player>> GetPlayersAsync(long teamId) =>
            await _request.GetResponseAsync<List<Player>>($"teams/{teamId}/players");

        public async Task<List<Hero>> GetHeroesAsync(long teamId) =>
            await _request.GetResponseAsync<List<Hero>>($"teams/{teamId}/heroes");
    }
}