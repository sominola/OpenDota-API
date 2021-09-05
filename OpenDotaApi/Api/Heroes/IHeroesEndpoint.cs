using System.Collections.Generic;
using System.Threading.Tasks;


namespace OpenDotaApi.Api.Heroes
{
    using Model;
    using Model.Duration;
    using Model.ItemPopularity;
    using Model.Matchup;
    public interface IHeroesEndpoint
    {
        Task<List<Hero>> GetDataAsync();
        Task<List<Model.Match.Match>> GetRecentMatchesAsync(int heroId);
        Task<List<Matchup>> GetMatchUpsAsync(int heroId);
        Task<List<Duration>> GetDurationsAsync(int heroId);
        Task<List<Model.Player.Player>> GetPlayersAsync(int heroId);
        Task<ItemPopularity> GetItemPopularityAsync(int heroId);
    }
}