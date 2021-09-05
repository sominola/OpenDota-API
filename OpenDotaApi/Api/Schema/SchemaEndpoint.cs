using System.Collections.Generic;
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

        public async Task<List<Schema>> GetDataSchemaAsync() =>
            await _formatter.DeserializeAsync<List<Schema>>("schema");
    }
}