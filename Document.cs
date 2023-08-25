using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TradingToolbox.System.Data.NoSql.MongoDB.Models
{
    /// <summary>
    /// Base (abstract) document implementation for MongoDB repository implementation.
    /// </summary>
    public abstract class Document : IDocument
    {
        /// <summary>
        /// Unique document identifier; to be assigned by database when document is created.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// Document's creatation date/time.
        /// </summary>
        [BsonIgnore]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime CreatedAt => (new ObjectId(this.Id)).CreationTime;
    }
}