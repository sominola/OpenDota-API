using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Teams
{
    using Model;
    using Model.Match;
    using Model.Player;
    using Model.Hero;

    public interface ITeamsEndpoint
    {
        Task<List<Team>> GetTeamsAsync();
        Task<Team> GetTeamByIdAsync(long teamId);
        Task<List<Match>> GetMatchesAsync(long teamId);
        Task<List<Player>> GetPlayersAsync(long teamId);
        Task<List<Hero>> GetHeroesAsync(long teamId);
    }
}