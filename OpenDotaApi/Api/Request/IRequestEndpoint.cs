using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Request
{
    using Model;

    public interface IRequestEndpoint
    {
        Task<ParseRequestState> GetParseRequestStateAsync(long jobId, CancellationToken? token = default);

        Task<ParseRequest> SubmitNewParseRequestAsync(long matchId, CancellationToken? token = default);
    }
}