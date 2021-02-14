using System.Collections.Generic;
using System.Threading.Tasks;
using OpenDotaApi.Api.Search.Model;
using OpenDotaApi.Utilities;

namespace OpenDotaApi.Api.Search
{
    public class SearchEndpoint: ISearchEndpoint
    {
        private readonly RequestHandler _request;

        public SearchEndpoint(RequestHandler request)
        {
            _request = request;
        }

        public async Task<List<SearchPlayer>> GetListPlayersByNameAsync(string name) =>
            await _request.GetResponseAsync<List<SearchPlayer>>($"search",$"q={name}");
    }
}