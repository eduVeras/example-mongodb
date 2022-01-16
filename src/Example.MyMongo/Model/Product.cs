using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Text.Json.Serialization;

namespace Example.MyMongo.Model
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonIgnore]
        public string Id { get; set; }
        [BsonElement]
        public string Name { get; set; }
        
        [BsonElement]
        public decimal Price { get; set; }
        [BsonElement]
        public bool Active { get; set; }
        [BsonElement]
        public DateTime Created { get; set; }
        [BsonElement]
        public DateTime Updated { get; set; }

    }
}
