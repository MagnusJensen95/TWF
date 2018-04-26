using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WeddingFolderAPI.Models
{

    //Excluded extra fields to ensure functionality
    [BsonIgnoreExtraElements]
    public class Product
    {
        public ObjectId _id { get; set; }
        [BsonElement("ProductId")]
        public int ProductId { get; set; }
        [BsonElement("ProductName")]
        public string ProductName { get; set; }
        [BsonElement("Price")]
        public int Price { get; set; }
        [BsonElement("Category")]
        public string Category { get; set; }
        [BsonElement("Vendors")]
        public Vendor[] Vendors{ get; set; }
        //[BsonElement("FlottyFyre")]
        //public string fyre { get; set; }

    }
}
