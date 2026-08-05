using Wikipedia.Shared.DTOs;

namespace Wikipedia.WebUI.Services
{
    public interface IApiService
    {
        Task<List<WikiResultDto>> SearchWikipedia(string searchText);
    }
}
