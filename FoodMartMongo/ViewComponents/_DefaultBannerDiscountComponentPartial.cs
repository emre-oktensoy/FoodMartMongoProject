using FoodMartMongo.Services.DiscountService;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.ViewComponents
{
    public class _DefaultBannerDiscountComponentPartial : ViewComponent
    {
        private readonly IDiscountService _discountService;

        public _DefaultBannerDiscountComponentPartial(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _discountService.GetAllDiscountAsync();


            var first = values.Count > 0 ? values[0] : null;
            var second = values.Count > 1 ? values[1] : null;


            ViewBag.FirstDiscount = first;
            ViewBag.SecondDiscount = second;

            return View(values);
        }
    }
}
