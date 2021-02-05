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
    using Model.Pro;
    using Model.Totals;
    using Model.Histograms;
    using Model.WardMap;
    using Model.WordCloud;
    using Model.Ratings;
    using Model.Rankings;

    public interface IPlayerEndpoint
    {
        Task<Player> GetPlayerAsync(long playerId);

        Task<WinLoss> GetWinLossAsync(long playerId, PlayerParameters parameters = null);

        Task<List<RecentMatches>> GetRecentMatchesAsync(long playerId);

        Task<List<Matches>> GetMatchesAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Model.Heroes.Heroes>> GetHeroesAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Peers>> GetPeersAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Pro>> GetProAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Totals>> GetTotalsAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Histograms>> GetHistogramsAsync(long playerId, string field, PlayerParameters parameters = null);

        Task<List<WardMap>> GetWardMapAsync(long playerId, PlayerParameters parameters = null);

        Task<List<WordCloud>> GetWordCloudAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Ratings>> GetRatingsAsync(long playerId);

        Task<List<Rankings>> GetRankingsAsync(long playerId);

        Task<bool> RefreshPlayerMatchHistory(long playerId);
    }
}