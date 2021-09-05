using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.ParsedMatches
{
    using Model;

    public class ParsedMatchesEndpoint: IParsedMatchesEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public ParsedMatchesEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<ParsedMatch>> GetListParsedMatches(long? lessThanMatchId = null) =>
            await _formatter.DeserializeAsync<List<ParsedMatch>>("parsedMatches", lessThanMatchId == null? "":$"less_than_match_id={lessThanMatchId}");
    }
}