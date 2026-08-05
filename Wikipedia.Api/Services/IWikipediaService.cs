using Wikipedia.Shared.DTOs;

namespace Wikipedia.Api.Services
{
    public interface IWikipediaService
    {
        Task<List<WikiResultDto>> SearchAsync(string searchText);
    }
}
