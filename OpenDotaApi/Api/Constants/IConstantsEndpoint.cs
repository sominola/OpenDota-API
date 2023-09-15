using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Enums;

namespace OpenDotaApi.Api.Constants
{
    public interface IConstantsEndpoint
    {
        Task<long[]> GetGameConstantsAsync(EnumConstants constant, CancellationToken? token = default);
    }
}