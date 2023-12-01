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

            var responseString = await _httpClient.GetStringAsync("creators?ts=1&apikey=a3b5b24ba6ba6a846a5e774e90e340b7&hash=6e94d8b4a9f883c9a1f732d5d4c9fd99");
            var root = JsonConvert.DeserializeObject<Root>(responseString);
            return root.Data.Results;
        }
    }
}
