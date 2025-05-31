
using FoodMartMongo.Dtos.DiscountDtos;
using FoodMartMongo.Services.DiscountService;
using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongo.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public async Task<IActionResult> DiscountList()
        {
            var values = await _discountService.GetAllDiscountAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateDiscount()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            await _discountService.CreateDuscountAsync(createDiscountDto);
            return RedirectToAction("DiscountList");
        }

        public async Task<IActionResult> DeleteDiscount(string id)
        {
            await _discountService.DeleteDiscountAsync(id);
            return RedirectToAction("DiscountList");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateDiscount(string id)
        {
            var value = await _discountService.GetDiscountByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            await _discountService.UpdateDiscountAsync(updateDiscountDto);
            return RedirectToAction("DiscountList");
        }
    }
}
