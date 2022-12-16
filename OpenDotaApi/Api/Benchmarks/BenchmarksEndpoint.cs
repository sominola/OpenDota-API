using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Benchmarks
{
    using Model;
    public class BenchmarksEndpoint: IBenchmarksEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public BenchmarksEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }
        public async Task<Benchmarks> GetStatValuesByIdHeroAsync(int idHero, CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<Benchmarks>($"benchmarks",$"hero_id={idHero}", token);
    }
}