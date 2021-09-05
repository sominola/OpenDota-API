using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Enums;

namespace OpenDotaApi.Api.Records
{
    using Model;

    public interface IRecordsEndpoint
    {
        Task<List<Record>> GetRecordsByFieldAsync(RecordField fields);
    }
}