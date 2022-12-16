using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Teams
{
    using Model;
    using Model.Match;
    using Model.Player;
    using Model.Hero;

    public interface ITeamsEndpoint
    {
        Task<List<Team>> GetTeamsAsync(CancellationToken? token = default);
        Task<Team> GetTeamByIdAsync(long teamId, CancellationToken? token = default);
        Task<List<Match>> GetMatchesAsync(long teamId, CancellationToken? token = default);
        Task<List<Player>> GetPlayersAsync(long teamId, CancellationToken? token = default);
        Task<List<Hero>> GetHeroesAsync(long teamId, CancellationToken? token = default);
    }
}