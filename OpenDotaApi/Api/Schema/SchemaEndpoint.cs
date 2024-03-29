using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Schema
{
    using Model;

    public class SchemaEndpoint : ISchemaEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public SchemaEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<Schema>> GetDataSchemaAsync(CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<List<Schema>>("schema", null, token);
    }
}