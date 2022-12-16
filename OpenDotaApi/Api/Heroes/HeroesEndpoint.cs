using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Api.Heroes.Model;
using OpenDotaApi.Api.Heroes.Model.Duration;
using OpenDotaApi.Api.Heroes.Model.ItemPopularity;
using OpenDotaApi.Api.Heroes.Model.Matchup;
using OpenDotaApi.Utilities;


namespace OpenDotaApi.Api.Heroes;

using Model.Match;
using Model.Player;
public class HeroesEndpoint : IHeroesEndpoint
{
    private readonly JsonFormatter _formatter;

    public HeroesEndpoint(JsonFormatter formatter)
    {
        _formatter = formatter;
    }

    public async Task<List<Hero>> GetDataAsync(CancellationToken? token = default) =>
        await _formatter.DeserializeAsync<List<Hero>>("heroes");

    public async Task<List<Match>>
        GetRecentMatchesAsync(int heroId, CancellationToken? token = default) =>
        await _formatter.DeserializeAsync<List<Match>>($"heroes/{heroId}/matches", null,token);

    public async Task<List<Matchup>> GetMatchUpsAsync(int heroId, CancellationToken? token = default) =>
        await _formatter.DeserializeAsync<List<Matchup>>($"heroes/{heroId}/matchups", null, token);

    public async Task<List<Duration>> GetDurationsAsync(int heroId, CancellationToken? token = default) =>
        await _formatter.DeserializeAsync<List<Duration>>($"heroes/{heroId}/durations", null, token);

    public async Task<List<Player>> GetPlayersAsync(int heroId, CancellationToken? token = default) =>
        await _formatter.DeserializeAsync<List<Player>>($"heroes/{heroId}/players", null, token);

    public async Task<ItemPopularity> GetItemPopularityAsync(int heroId, CancellationToken? token = default) =>
        await _formatter.DeserializeAsync<ItemPopularity>($"heroes/{heroId}/itemPopularity", null, token);
}