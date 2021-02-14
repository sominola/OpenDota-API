using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using OpenDotaApi.Api.Request.Model;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Request
{
    public class RequestEndpoint : IRequestEndpoint
    {
        private readonly RequestHandler _request;

        public RequestEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<ParseRequestState> GetParseRequestStateAsync(long jobId) =>
            await _request.GetResponseAsync<ParseRequestState>($"request/{jobId}");

        public async Task<ParseRequest> SubmitNewParseRequestAsync(long matchId)
        {
            var response = await _request.PostRequestAsync($"players/{matchId}/refresh");
            response.EnsureSuccessStatusCode();
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<ParseRequest>(responseText);
        }
    }
}