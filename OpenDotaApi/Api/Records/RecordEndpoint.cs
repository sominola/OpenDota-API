using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;
using OpenDotaApi.Enums;
namespace OpenDotaApi.Api.Records
{
    using Model;
    public class RecordEndpoint: IRecordEndpoint
    {
        private readonly RequestHandler _request;

        public RecordEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<Record>> GetRecordsByField(RecordField field)
        {
            var result = Regex.Replace(field.ToString(), "([a-z])([A-Z])", "$1_$2").ToLower();
            return await _request.GetResponseAsync<List<Record>>($"records/{result}");
        }
    }
}