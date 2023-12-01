using Infrastructure.Interfaces;
using Infrastructure.Interfaces.MarvelService;
using Newtonsoft.Json;

namespace Infrastructure.Services
{
    public class MarvelService : IMarvelService
    {
        private readonly HttpClient _httpClient;

        public MarvelService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CreatorResult>> GetCreatorsAsync()
        {

            var responseString = await _httpClient.GetStringAsync("");
            var root = JsonConvert.DeserializeObject<Root>(responseString);
            return root.Data.Results;
        }
    }
}
