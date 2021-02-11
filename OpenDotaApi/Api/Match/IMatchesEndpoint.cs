using System.Threading.Tasks;

namespace OpenDotaApi.Api.Match
{
    using Model;

    public interface IMatchesEndpoint
    {
        Task<Match> GetMatchAsync(long matchId);
    }
}