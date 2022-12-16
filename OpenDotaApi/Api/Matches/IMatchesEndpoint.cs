using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Api.Matches.Model;

namespace OpenDotaApi.Api.Matches
{
    public interface IMatchesEndpoint
    {
        Task<Match> GetMatchAsync(long matchId, CancellationToken? token = default);
    }
}