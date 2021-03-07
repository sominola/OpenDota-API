using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.PublicMatch
{
    using Model;
    public class PublicMatchEndpoint : IPublicMatchEndpoint
    {
        private readonly RequestHandler _request;

        public PublicMatchEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<PublicMatch>> GetListPublicMatchesAsync(int? mmrAscending = null, int? mmrDescending = null, long? lessThanMatchId = null)
        {
            var param = "";
            if (mmrAscending != null)
                param += $"&mmr_ascending={mmrAscending}";
            if (mmrDescending !=null)
                param += $"&mmr_descending={mmrDescending}";
            if (lessThanMatchId != null)
                param += $"less_than_match_id={lessThanMatchId}";
            return await _request.GetResponseAsync<List<PublicMatch>>("publicMatches",param);
        }
    }
}