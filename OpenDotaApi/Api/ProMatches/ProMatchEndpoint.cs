using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.ProMatches
{
    using Model;

    public class ProMatchesEndpoint : IProMatchesEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public ProMatchesEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<ProMatch>> GetListProMatchesAsync(long? lessThanMatchId = null) =>
            await _formatter.DeserializeAsync<List<ProMatch>>("proMatches", lessThanMatchId == null ? "" : $"&less_than_match_id={lessThanMatchId}");
    }
}