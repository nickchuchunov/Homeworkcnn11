using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SecureDevelopment_1
{
    public class BookContract
    {
       public  BookContract() { }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
       public string? BookId { get; set; }
        [BsonElement("BookTitle")]
       public string? BookTitle { get; set; }

        [BsonElement("NumberPages")]
        public int? NumberPages { get; set; }

        [BsonElement("Language")]
        public string? Language { get; set; }

        [BsonElement("Author")]
        public string? Author { get; set; }

        [BsonElement("ISBN")]
        public string? ISBN { get; set; }

    }
}
