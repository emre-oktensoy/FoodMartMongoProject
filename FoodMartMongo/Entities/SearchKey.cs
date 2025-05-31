using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FoodMartMongo.Entities
{
    public class SearchKey
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SearchKeyId { get; set; }
        public string Title { get; set; }
       
    }
}
