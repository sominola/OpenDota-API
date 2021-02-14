using System.Threading.Tasks;

namespace OpenDotaApi.Api.Benchmarks
{
    using Model;
    public interface IBenchmarksEndpoint
    {
        Task<Benchmarks> GetStatValuesByIdHeroAsync(int idHero);
    }
}