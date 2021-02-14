using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Rankings
{
    using Model;
    public class RankingsEndpoint: IRankingsEndpoint
    {
        private readonly RequestHandler _request;
        public RankingsEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<Rankings> GetTopPlayersByHero(int idHero) =>
            await _request.GetResponseAsync<Rankings>($"rankings",$"hero_id={idHero}");

    }
}