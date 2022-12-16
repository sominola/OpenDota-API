using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace OpenDotaApi.Api.Heroes;

using Model;
using Model.Duration;
using Model.ItemPopularity;
using Model.Matchup;
using Model.Match;
using Model.Player;

public interface IHeroesEndpoint
{
    Task<List<Hero>> GetDataAsync(CancellationToken? token = default);
    Task<List<Match>> GetRecentMatchesAsync(int heroId, CancellationToken? token = default);
    Task<List<Matchup>> GetMatchUpsAsync(int heroId, CancellationToken? token = default);
    Task<List<Duration>> GetDurationsAsync(int heroId, CancellationToken? token = default);
    Task<List<Player>> GetPlayersAsync(int heroId, CancellationToken? token = default);
    Task<ItemPopularity> GetItemPopularityAsync(int heroId, CancellationToken? token = default);
}