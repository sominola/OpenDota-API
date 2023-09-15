using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;
using OpenDotaApi.Enums;

namespace OpenDotaApi.Api.Constants
{
    public class ConstantsEndpoint : IConstantsEndpoint
    {
        private readonly JsonFormatter _formatter;

        public ConstantsEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<long[]> GetGameConstantsAsync(EnumConstants constant, CancellationToken? token = default)
        {
            var parameter = Regex.Replace(constant.ToString(), "([a-z])([A-Z])", "$1_$2").ToLower();
            return await _formatter.DeserializeAsync<long[]>($"constants/{parameter}",
                cancellationToken: token.GetValueOrDefault());
        }
    }
}