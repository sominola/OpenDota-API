using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Status
{
    using Model;
    public class StatusEndpoint: IStatusEndpoint
    {
        private readonly RequestHandler _request;

        public StatusEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<Status> GetServiceStatisticsAsync() =>
            await _request.GetResponseAsync<Status>("status");
    }
}