using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDotaApi.Api.Search
{
    using Model;
    public interface ISearchEndpoint
    {
        Task<List<SearchPlayer>> GetListPlayersByNameAsync(string name);
    }
}