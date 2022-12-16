using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Distributions
{
    using Model;
    public interface IDistributionsEndpoint
    {
        Task<Distributions> GetDistributionsAsync(CancellationToken? token = default);
    }
}