using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Example.MyMongo.Model
{
    public class Product
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

    }
}
