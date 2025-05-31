using FoodMartMongo.Services.DiscountService;

using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.ViewComponents
{
    public class _DefaultDiscountComponentPartial : ViewComponent
    {
        private readonly IDiscountService _discountService;

        public _DefaultDiscountComponentPartial(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _discountService.GetAllDiscountAsync();
            

            var third = values.Count > 2 ? values[2] : null;
            var fourth = values.Count > 3 ? values[3] : null;

            
            ViewBag.ThirdDiscount = third;
            ViewBag.FourthDiscount = fourth;

            return View(values);
        }
    }
}
