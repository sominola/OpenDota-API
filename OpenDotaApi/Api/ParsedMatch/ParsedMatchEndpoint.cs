using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.ParsedMatch
{
    using Model;
    public class ParsedMatchEndpoint: IParsedMatchEndpoint
    {
        private readonly RequestHandler _request;

        public ParsedMatchEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<ParsedMatch>> GetListParsedMatches(long? lessThanMatchId = null) =>
            await _request.GetResponseAsync<List<ParsedMatch>>("parsedMatches", lessThanMatchId == null? "":$"less_than_match_id={lessThanMatchId}");
    }
}