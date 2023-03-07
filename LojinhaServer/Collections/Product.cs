using System.ComponentModel.DataAnnotations.Schema;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace LojinhaServer.Collections;

    [Table("products")]
    [BsonIgnoreExtraElements]
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        [JsonPropertyName("Nome")]
        public string Name { get; set; }

        [BsonElement("description")]
        [JsonPropertyName("Descrição")]
        public string Description { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }

        [BsonElement("offPrice")]
        public decimal offPrice { get; set; }

        [BsonElement("categories")]
        public List<string> Categories { get; set; }

        [BsonElement("tags")]
        public List<string> Tags { get; set; }

        [BsonElement("brand")]
        public List<string> Brand { get; set; }
    }
