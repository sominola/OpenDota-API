using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Schema
{
    using Model;

    public class SchemaEndpoint : ISchemaEndpoint
    {
        private readonly RequestHandler _request;

        public SchemaEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<Schema>> GetDataSchema() =>
            await _request.GetResponseAsync<List<Schema>>("schema");
    }
}