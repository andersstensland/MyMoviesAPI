using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MovieStoreApi.Models
{
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("name")]
        public string MovieName { get; set; } // Match the field name in MongoDB documents

        public string category { get; set; }

        public double imdb { get; set; }

        public string director { get; set; }

        public string image { get; set; }
    }
}
