using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Health
{
    using Model;
    public class HealthEndpoint: IHealthEndpoint
    {
        private readonly RequestHandler _request;

        public HealthEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<Health> GetServiceHealthDataAsync() =>
            await _request.GetResponseAsync<Health>("health");

    }
}