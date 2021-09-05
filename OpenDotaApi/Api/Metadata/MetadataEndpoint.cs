using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Metadata
{
    using Model;

    public class MetadataEndpoint : IMetadataEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public MetadataEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<Metadata> GetMetadataAsync() =>
            await _formatter.DeserializeAsync<Metadata>("metadata");
    }
}