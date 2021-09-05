using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Status
{
    using Model;
    public class StatusEndpoint: IStatusEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public StatusEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<Status> GetServiceStatisticsAsync() =>
            await _formatter.DeserializeAsync<Status>("status");
    }
}