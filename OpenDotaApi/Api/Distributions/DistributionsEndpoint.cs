using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Distributions
{
    using Model;

    public class DistributionsEndpoint : IDistributionsEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public DistributionsEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<Distributions> GetDistributionsAsync(CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<Distributions>("distributions", null, token);
    }
}