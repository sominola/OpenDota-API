using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace OpenDotaApi.Api.Players;

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
using Model.Matches;
using Heroes =  Model.Heroes;
using Model.Rankings;
public interface IPlayersEndpoint
{
    Task<Player> GetPlayerAsync(long playerId, CancellationToken? token = default);

    Task<WinLoss> GetWinLossAsync(long playerId, PlayerParameters parameters = null, CancellationToken? token = default);

    Task<List<RecentMatches>> GetRecentMatchesAsync(long playerId, CancellationToken? token = default);

    Task<List<Matches>> GetMatchesAsync(long playerId, PlayerParameters parameters = null, CancellationToken? token = default);

    Task<List<Heroes.Heroes>> GetHeroesAsync(long playerId, PlayerParameters parameters = null, CancellationToken? token = default);

    Task<List<Peers>> GetPeersAsync(long playerId, PlayerParameters parameters = null, CancellationToken? token = default);

    Task<List<Pro>> GetProAsync(long playerId, PlayerParameters parameters = null, CancellationToken? token = default);

    Task<List<Totals>> GetTotalsAsync(long playerId, PlayerParameters parameters = null, CancellationToken? token = default);

    Task<List<Histograms>> GetHistogramsAsync(long playerId, string field, PlayerParameters parameters = null, CancellationToken? token = default);

    Task<WardMap> GetWardMapAsync(long playerId, PlayerParameters parameters = null, CancellationToken? token = default);

    Task<WordCloud> GetWordCloudAsync(long playerId, PlayerParameters parameters = null, CancellationToken? token = default);

    Task<List<Ratings>> GetRatingsAsync(long playerId, CancellationToken? token = default);

    Task<List<Rankings>> GetRankingsAsync(long playerId, CancellationToken? token = default);

    Task<bool> RefreshPlayerMatchHistoryAsync(long playerId, CancellationToken? token = default);
}