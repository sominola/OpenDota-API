using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.ParsedMatches
{
    using Model;

    public interface IParsedMatchesEndpoint
    {
        Task<List<ParsedMatch>> GetListParsedMatches(long? lessThanMatchId = null);
    }
}