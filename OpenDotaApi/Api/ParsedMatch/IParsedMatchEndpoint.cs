using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.ParsedMatch
{
    using Model;
    public interface IParsedMatchEndpoint
    {
        Task<List<ParsedMatch>> GetListParsedMatches();
    }
}