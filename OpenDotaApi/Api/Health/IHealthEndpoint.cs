using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Health
{
    using Model;
    public interface IHealthEndpoint
    {
        Task<Health> GetServiceHealthDataAsync(CancellationToken? token = default);
    }
}