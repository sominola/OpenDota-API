using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.PublicMatches
{
    using Model;

    public class PublicMatchesEndpoint : IPublicMatchesEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public PublicMatchesEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<PublicMatch>> GetListPublicMatchesAsync(int? mmrAscending = null, int? mmrDescending = null, long? lessThanMatchId = null, CancellationToken? token = default)
        {
            var param = "";
            if (mmrAscending != null)
                param += $"&mmr_ascending={mmrAscending}";
            if (mmrDescending !=null)
                param += $"&mmr_descending={mmrDescending}";
            if (lessThanMatchId != null)
                param += $"less_than_match_id={lessThanMatchId}";
            return await _formatter.DeserializeAsync<List<PublicMatch>>("publicMatches",param, token);
        }
    }
}