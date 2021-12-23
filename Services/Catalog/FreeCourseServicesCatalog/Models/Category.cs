using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourseServicesCatalog.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
