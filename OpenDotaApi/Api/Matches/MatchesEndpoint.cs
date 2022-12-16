using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Matches
{
    using Model;

    public class MatchesEndpoint : IMatchesEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public MatchesEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }
        
        public async Task<Match> GetMatchAsync(long matchId, CancellationToken? token = default) =>
           await _formatter.DeserializeAsync<Match>($"matches/{matchId}", null, token);
    }
}