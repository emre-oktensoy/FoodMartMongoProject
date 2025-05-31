

using FoodMartMongo.Dtos.DiscountDtos;

namespace FoodMartMongo.Services.DiscountService
{
    public interface IDiscountService
    {

        Task<List<ResultDiscountDto>> GetAllDiscountAsync();       
        Task CreateDuscountAsync(CreateDiscountDto createDiscountDto);
        Task UpdateDiscountAsync(UpdateDiscountDto updateDiscountDto);
        Task DeleteDiscountAsync(string id);
        Task<GetDiscountByIdDto> GetDiscountByIdAsync(string id);
    }
}
