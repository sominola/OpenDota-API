using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Benchmarks
{
    using Model;
    public class BenchmarksEndpoint: IBenchmarksEndpoint
    {
        private readonly RequestHandler _request;

        public BenchmarksEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<Benchmarks> GetStatValuesByIdHeroAsync(int idHero) =>
            await _request.GetResponseAsync<Benchmarks>($"benchmarks",$"hero_id={idHero}");
    }
}