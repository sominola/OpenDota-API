using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;
using OpenDotaApi.Enums;

namespace OpenDotaApi.Api.Constants
{
    public class ConstantsEndpoint : IConstantsEndpoint
    {
        private readonly RequestHandler _request;

        public ConstantsEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<string> GetGameConstantsAsync(EnumConstants constant, CancellationToken? token = default)
        {
            var parameter = Regex.Replace(constant.ToString(), "([a-z])([A-Z])", "$1_$2").ToLower();
            var response = await _request.GetResponseAsync($"constants/{parameter}", cancellationToken: token.GetValueOrDefault());
            return await response.Content.ReadAsStringAsync();
        }
    }
}