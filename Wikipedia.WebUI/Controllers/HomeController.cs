using Microsoft.AspNetCore.Mvc;
using Wikipedia.WebUI.Models;
using Wikipedia.WebUI.Services;

namespace Wikipedia.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApiService _apiService;

        public HomeController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(SearchViewModel model)
        {
            model.Results =
                await _apiService.SearchWikipedia(
                    model.SearchText);

            return View(model);
        }
    }
}
