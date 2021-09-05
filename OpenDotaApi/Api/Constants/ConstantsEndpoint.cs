using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;
using OpenDotaApi.Enums;

namespace OpenDotaApi.Api.Constants
{
    public class ConstantsEndpoint: IConstantsEndpoint
    {
        private readonly JsonFormatter _formatter;
        private readonly RequestHandler _request;

        public ConstantsEndpoint(JsonFormatter formatter, RequestHandler request)
        {
            _formatter = formatter;
            _request = request;
        }

        public async Task<string> GetGameConstantsAsync(EnumConstants constant)
        {
            var parameter = Regex.Replace(constant.ToString(), "([a-z])([A-Z])", "$1_$2").ToLower();
            var response = await _request.GetResponseAsync($"constants/{parameter}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}