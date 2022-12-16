using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Api.Request.Model;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Request
{
    public class RequestEndpoint : IRequestEndpoint
    {
        private readonly JsonFormatter _formatter;
        private readonly RequestHandler _request;
        
        public RequestEndpoint(JsonFormatter formatter, RequestHandler request)
        {
            _formatter = formatter;
            _request = request;
        }

        public async Task<ParseRequestState> GetParseRequestStateAsync(long jobId, CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<ParseRequestState>($"request/{jobId}",cancellationToken:token);

        public async Task<ParseRequest> SubmitNewParseRequestAsync(long matchId, CancellationToken? token = default)
        {
            var response = await _request.PostRequestAsync($"request/{matchId}");
            var responseStream = await response.Content.ReadAsStreamAsync();
            return await _formatter.DeserializeAsync<ParseRequest>(responseStream, cancellationToken:token);
        }
    }
}