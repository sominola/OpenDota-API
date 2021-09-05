using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;
using OpenDotaApi.Enums;
namespace OpenDotaApi.Api.Records
{
    using Model;
    public class RecordsEndpoint: IRecordsEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public RecordsEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<Record>> GetRecordsByFieldAsync(RecordField field)
        {
            var result = Regex.Replace(field.ToString(), "([a-z])([A-Z])", "$1_$2").ToLower();
            return await _formatter.DeserializeAsync<List<Record>>($"records/{result}");
        }
    }
}