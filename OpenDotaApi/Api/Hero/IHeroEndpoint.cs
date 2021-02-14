using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Hero
{
    using Model;
    using Model.Match;
    using Model.Matchup;
    using Model.Duration;
    using Model.Player;
    using Model.ItemPopularity;

    public interface IHeroEndpoint
    {
        Task<List<Hero>> GetDataAsync();
        Task<List<Match>> GetRecentMatchesAsync(int heroId);
        Task<List<Matchup>> GetMatchupsAsync(int heroId);
        Task<List<Duration>> GetDurationsAsync(int heroId);
        Task<List<Player>> GetPlayersAsync(int heroId);
        Task<ItemPopularity> GetItemPopularity(int heroId);
    }
}