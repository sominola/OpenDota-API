using System.Threading.Tasks;

namespace OpenDotaApi.Api.Rankings
{
    using Model;
    public interface IRankingsEndpoint
    {
        Task<Rankings> GetTopPlayersByHero(int idHero);
    }
}