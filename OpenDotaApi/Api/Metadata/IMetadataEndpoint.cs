using System.Threading.Tasks;

namespace OpenDotaApi.Api.Metadata
{
    using Model;
    public interface IMetadataEndpoint
    {
        Task<Metadata> GetMetadataAsync();
    }
}