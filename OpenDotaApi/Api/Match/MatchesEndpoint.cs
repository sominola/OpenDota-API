using System.Threading.Tasks;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Match
{
    using Model;
    
    public class MatchesEndpoint : IMatchesEndpoint
    {
        private readonly RequestHandler _request;
        
        public MatchesEndpoint(RequestHandler requestHandler)
        {
           this._request = requestHandler;
        }
        public async Task<Match> GetMatchAsync(long matchId) =>
           await _request.GetResponseAsync<Match>($"matches/{matchId}");
    }
}