
using FoodMartMongo.Dtos.SearchKeyDtos;

namespace FoodMartMongo.Services.SearchKeyService
{
    public interface ISearchKeyService
    {

        Task<List<ResultSearchKeyDto>> GetAllSearchKeyAsync();
        Task CreateSearchKeyAsync(CreateSearchKeyDto createSearchKeyDto);
        Task UpdateSearchKeyAsync(UpdateSearchKeyDto updateSearchKeyDto);
        Task DeleteSearchKeyAsync(string id);
        Task<GetSearchKeyByIdDto> GetSearchKeyByIdAsync(string id);
    }
}
