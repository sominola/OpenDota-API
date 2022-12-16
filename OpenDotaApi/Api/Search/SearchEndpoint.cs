using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OpenDotaApi.Api.Search.Model;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Search
{
    public class SearchEndpoint: ISearchEndpoint
    {
        private readonly JsonFormatter _formatter;
        
        public SearchEndpoint(JsonFormatter formatter)
        {
            _formatter = formatter;
        }

        public async Task<List<SearchPlayer>> GetListPlayersByNameAsync(string name,
            CancellationToken? token = default) =>
            await _formatter.DeserializeAsync<List<SearchPlayer>>($"search",$"q={name}", token);
    }
}