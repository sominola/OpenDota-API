using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Rankings
{
    using Model;
    public class RankingsEndpoint: IRankingsEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public RankingsEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<Rankings> GetTopPlayersByHeroAsync(int idHero) =>
            await _formatter.DeserializeAsync<Rankings>($"rankings",$"hero_id={idHero}");

    }
}