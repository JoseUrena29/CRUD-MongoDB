using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDataBase.Models
{
    public class Users
    {
        [BsonId]
        public ObjectId? _id { get; set; }

        [BsonElement("name")]
        public string? name { get; set; }

        [BsonElement("email")]
        public string? email { get; set; }

        [BsonElement("phone")]
        public Int32? phone { get; set; }

        [BsonElement("address")]
        public string? address { get; set; }

        [BsonElement("datein")]
        public DateTime? datein { get; set; }
    }
}
