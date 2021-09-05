using System.Collections.Generic;
using System.Threading.Tasks;


namespace OpenDotaApi.Api.Players
{
    using Model;
    using Model.Histograms;
    using Model.Peers;
    using Model.Pro;
    using Model.Ratings;
    using Model.RecentMatches;
    using Model.Totals;
    using Model.WardMap;
    using Model.WinLoss;
    using Model.WordCloud;
    public interface IPlayersEndpoint
    {
        Task<Player> GetPlayerAsync(long playerId);

        Task<WinLoss> GetWinLossAsync(long playerId, PlayerParameters parameters = null);

        Task<List<RecentMatches>> GetRecentMatchesAsync(long playerId);

        Task<List<Model.Matches.Matches>> GetMatchesAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Model.Heroes.Heroes>> GetHeroesAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Peers>> GetPeersAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Pro>> GetProAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Totals>> GetTotalsAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Histograms>> GetHistogramsAsync(long playerId, string field, PlayerParameters parameters = null);

        Task<WardMap> GetWardMapAsync(long playerId, PlayerParameters parameters = null);

        Task<WordCloud> GetWordCloudAsync(long playerId, PlayerParameters parameters = null);

        Task<List<Ratings>> GetRatingsAsync(long playerId);

        Task<List<Model.Rankings.Rankings>> GetRankingsAsync(long playerId);

        Task<bool> RefreshPlayerMatchHistoryAsync(long playerId);
    }
}