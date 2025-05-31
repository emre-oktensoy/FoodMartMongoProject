
using FoodMartMongo.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.ViewComponents
{
    public class _DefaultBestSellingProductsComponentPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultBestSellingProductsComponentPartial(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _productService.GetAllProductsAsync();

            var specialValues = values.OrderBy(x => x.Price).Take(6).ToList();

            return View(specialValues);
        }
    }
    
}
