using MongoDB.Bson.Serialization.Attributes;
using InsightMailUI.Models;
namespace InsightMailUI.Models
{ 

        public class SearchResult
        {
            public Email Email { get; set; }
            [BsonElement("score")]
            [BsonIgnoreIfNull]
            public float? Score { get; set; }
        }
    

}
