using Wikipedia.Shared.DTOs;

namespace Wikipedia.WebUI.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<WikiResultDto>> SearchWikipedia(string searchText)
        {
            var request = new SearchRequestDto
            {
                SearchText = searchText
            };

            var response =
                await _httpClient.PostAsJsonAsync(
                    "api/wikipedia/search",
                    request);

            response.EnsureSuccessStatusCode();

            var result =
                await response.Content
                              .ReadFromJsonAsync<List<WikiResultDto>>();

            return result ?? new List<WikiResultDto>();
        }
    }
}
