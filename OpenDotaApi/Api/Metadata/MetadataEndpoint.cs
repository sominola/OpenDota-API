using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Metadata
{
    using Model;

    public class MetadataEndpoint : IMetadataEndpoint
    {
        private readonly RequestHandler _request;

        public MetadataEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<Metadata> GetMetadataAsync() =>
            await _request.GetResponseAsync<Metadata>("metadata");
    }
}