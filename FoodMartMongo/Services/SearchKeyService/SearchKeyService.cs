using AutoMapper;
using FoodMartMongo.Dtos.SearchKeyDtos;
using FoodMartMongo.Entities;
using FoodMartMongo.Settings;
using MongoDB.Driver;

namespace FoodMartMongo.Services.SearchKeyService
{
    public class SearchKeyService : ISearchKeyService
    {
        private readonly IMongoCollection<SearchKey> _searchKeyCollection;
        private readonly IMapper _mapper;

        public SearchKeyService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _searchKeyCollection = database.GetCollection<SearchKey>(_databaseSettings.SearchKeyCollectionName);
            _mapper = mapper;
        }

        public async Task CreateSearchKeyAsync(CreateSearchKeyDto createSearchKeyDto)
        {
            var value = _mapper.Map<SearchKey>(createSearchKeyDto);
            await _searchKeyCollection.InsertOneAsync(value);
        }

        public async Task DeleteSearchKeyAsync(string id)
        {
            await _searchKeyCollection.DeleteOneAsync(x => x.SearchKeyId == id);
        }

        public async Task<List<ResultSearchKeyDto>> GetAllSearchKeyAsync()
        {
            var values = await _searchKeyCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultSearchKeyDto>>(values); ;
        }

        public async Task<GetSearchKeyByIdDto> GetSearchKeyByIdAsync(string id)
        {
            var value = await _searchKeyCollection.Find(x => x.SearchKeyId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetSearchKeyByIdDto>(value);
        }

        public async Task UpdateSearchKeyAsync(UpdateSearchKeyDto updateSearchKeyDto)
        {
            var value = _mapper.Map<SearchKey>(updateSearchKeyDto);
            await _searchKeyCollection.FindOneAndReplaceAsync(x => x.SearchKeyId == updateSearchKeyDto.SearchKeyId, value);
        }
    }
}
