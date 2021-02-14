using System.Threading.Tasks;

namespace OpenDotaApi.Api.Constants
{
    public interface IConstantsEndpoint
    {
        Task<string> GetGameConstantsAsync(EnumConstants constant);
    }
}