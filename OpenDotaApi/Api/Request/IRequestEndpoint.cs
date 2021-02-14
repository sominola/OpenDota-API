using System.Threading.Tasks;

namespace OpenDotaApi.Api.Request
{
    using Model;
    public interface IRequestEndpoint
    {
        Task<ParseRequestState> GetParseRequestStateAsync(long jobId);

        Task<ParseRequest> SubmitNewParseRequestAsync(long matchId);
    }
}