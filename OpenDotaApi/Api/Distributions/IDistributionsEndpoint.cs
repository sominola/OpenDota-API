using System.Threading.Tasks;

namespace OpenDotaApi.Api.Distributions
{
    using Model;
    public interface IDistributionsEndpoint
    {
        Task<Distributions> GetDistributionsAsync();
    }
}