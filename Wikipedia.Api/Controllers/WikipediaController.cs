using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wikipedia.Api.Services;
using Wikipedia.Shared.DTOs;

namespace Wikipedia.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WikipediaController : ControllerBase
    {
        private readonly IWikipediaService _wikipediaService;

        public WikipediaController(IWikipediaService wikipediaService)
        {
            _wikipediaService = wikipediaService;
        }

        [HttpPost("search")]
        public async Task<IActionResult> Search(SearchRequestDto request)
        {
            var result =
                await _wikipediaService.SearchAsync(request.SearchText);

            return Ok(result);
        }
    }
}
