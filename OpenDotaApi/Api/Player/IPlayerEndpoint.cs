using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Player
{
    using Model;
    using Model.WinLoss;
    using Model.RecentMatches;
    using Model.Matches;
    using Model.Heroes;
    using Model.Peers;
    using Model.Pros;
    using Model.Totals;
    public interface IPlayerEndpoint
    {
        Task<Player> GetPlayerAsync(long playerId);

        Task<WinLoss> GetWinLossAsync(long playerId, PlayerParameters parameters = null);

        Task<List<RecentMatches>> GetRecentMatchesAsync(long playerId);

        Task<List<Matches>> GetMatchesAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Model.Heroes.Heroes>> GetHeroesAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Peers>> GetPeersAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Pros>> GetProsAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Totals>> GetTotalsAsync(long playerId, PlayerParameters parameters = null);
        
        
    }
}