using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Health
{
    using Model;
    public class HealthEndpoint: IHealthEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public HealthEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<Health> GetServiceHealthDataAsync() =>
            await _formatter.DeserializeAsync<Health>("health");

    }
}