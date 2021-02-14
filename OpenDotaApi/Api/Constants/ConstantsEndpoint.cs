using System.Text.RegularExpressions;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Constants
{
    public class ConstantsEndpoint: IConstantsEndpoint
    {
        private readonly RequestHandler _request;

        public ConstantsEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<string> GetGameConstantsAsync(EnumConstants constant)
        {
            var parameter = Regex.Replace(constant.ToString(), "([a-z])([A-Z])", "$1_$2").ToLower();
            return await _request.GetStringAsync($"constants/{parameter}");
        }
    }
}