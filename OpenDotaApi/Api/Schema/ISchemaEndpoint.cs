using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Schema
{
    using Model;
    public interface ISchemaEndpoint
    {
        Task<List<Schema>> GetDataSchemaAsync(CancellationToken? token = default);
    }
}