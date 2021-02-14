using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Distributions
{
    using Model;

    public class DistributionsEndpoint : IDistributionsEndpoint
    {
        private readonly RequestHandler _request;

        public DistributionsEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<Distributions> GetDistributionsAsync() =>
            await _request.GetResponseAsync<Distributions>("distributions");
    }
}