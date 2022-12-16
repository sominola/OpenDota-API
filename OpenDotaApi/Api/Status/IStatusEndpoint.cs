using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Status
{
    using Model;
    public interface IStatusEndpoint
    {
        Task<Status> GetServiceStatisticsAsync(CancellationToken? token = default);
    }
}