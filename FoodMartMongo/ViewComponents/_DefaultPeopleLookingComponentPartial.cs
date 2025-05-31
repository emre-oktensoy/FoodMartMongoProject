using FoodMartMongo.Services.CategoryServices;
using FoodMartMongo.Services.SearchKeyService;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.ViewComponents
{
    public class _DefaultPeopleLookingComponentPartial : ViewComponent
    {
        private readonly ISearchKeyService _searchKeyService;

        public _DefaultPeopleLookingComponentPartial(ISearchKeyService searchKeyService)
        {
            _searchKeyService = searchKeyService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _searchKeyService.GetAllSearchKeyAsync();
            return View(values);
        }
    }
}
