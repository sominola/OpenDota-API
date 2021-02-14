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

        public async Task<List<ParsedMatch>> GetListParsedMatches() =>
            await _request.GetResponseAsync<List<ParsedMatch>>("parsedMatches");
    }
}