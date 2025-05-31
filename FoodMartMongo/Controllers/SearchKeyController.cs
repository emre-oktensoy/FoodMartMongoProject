
using FoodMartMongo.Dtos.SearchKeyDtos;
using FoodMartMongo.Services.SearchKeyService;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.Controllers
{
    public class SearchKeyController : Controller
    {
        private readonly ISearchKeyService _searchKeyService;
        public SearchKeyController(ISearchKeyService searchKeyService)
        {
            _searchKeyService = searchKeyService;
        }
        public async Task<IActionResult> SearchKeyList()
        {
            var values = await _searchKeyService.GetAllSearchKeyAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSearchKey()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSearchKey(CreateSearchKeyDto createSearchKeyDto)
        {
            await _searchKeyService.CreateSearchKeyAsync(createSearchKeyDto);
            return RedirectToAction("SearchKeyList");
        }

        public async Task<IActionResult> DeleteSearchKey(string id)
        {
            await _searchKeyService.DeleteSearchKeyAsync(id);
            return RedirectToAction("SearchKeyList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSearchKey(string id)
        {
            var value = await _searchKeyService.GetSearchKeyByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSearchKey(UpdateSearchKeyDto updateSearchKeyDto)
        {
            await _searchKeyService.UpdateSearchKeyAsync(updateSearchKeyDto);
            return RedirectToAction("SearchKeyList");
        }
    }
}
