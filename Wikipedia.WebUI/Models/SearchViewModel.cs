using Wikipedia.Shared.DTOs;

namespace Wikipedia.WebUI.Models
{
    public class SearchViewModel
    {
        public string SearchText { get; set; } = string.Empty;

        public List<WikiResultDto> Results { get; set; } = new();
    }
}
