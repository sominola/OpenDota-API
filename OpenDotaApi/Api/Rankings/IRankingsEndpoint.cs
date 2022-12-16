using System.Threading;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Rankings
{
    using Model;
    public interface IRankingsEndpoint
    {
        Task<Rankings> GetTopPlayersByHeroAsync(int idHero, CancellationToken? token = default);
    }
}