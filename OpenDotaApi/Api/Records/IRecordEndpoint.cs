using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Records
{
    using Model;

    public interface IRecordEndpoint
    {
        Task<List<Record>> GetRecordsByField(RecordField fields);
    }
}