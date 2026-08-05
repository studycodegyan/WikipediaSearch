using System.Text.Json;
using Wikipedia.Shared.DTOs;

namespace Wikipedia.Api.Services
{
    public class WikipediaService : IWikipediaService
    {
        private readonly HttpClient _httpClient;

        public WikipediaService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            _httpClient.DefaultRequestHeaders.Add(
        "User-Agent",
        "WikipediaSearchApp/1.0");
        }
        //public Task<List<WikiResultDto>> SearchAsync(string searchText)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<List<WikiResultDto>> SearchAsync(string searchText)
        {
            var encodedText = Uri.EscapeDataString(searchText);
            //var url = $"https://en.wikipedia.org/w/api.php?action=opensearch&search={searchText}&limit=10&namespace=0&format=json";
            var url = $"https://en.wikipedia.org/w/api.php?action=opensearch&search={encodedText}&limit=10&namespace=0&format=json";

            var response = await _httpClient.GetStringAsync(url);

            using JsonDocument document = JsonDocument.Parse(response);

            var results = new List<WikiResultDto>();

            var titles = document.RootElement[1];
            var descriptions = document.RootElement[2];
            var links = document.RootElement[3];

            for (int i = 0; i < titles.GetArrayLength(); i++)
            {
                results.Add(new WikiResultDto
                {
                    Title = titles[i].GetString() ?? "",
                    Description = descriptions[i].GetString() ?? "",
                    Url = links[i].GetString() ?? ""
                });
            }

            return results;
        }
    }
}
