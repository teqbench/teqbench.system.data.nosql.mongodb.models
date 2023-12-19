using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TeqBench.System.Data.NoSql.MongoDB.Models
{
    /// <summary>
    /// Base (abstract) document implementation for MongoDB repository implementation.
    /// </summary>
    public abstract class Document : IDocument
    {
        #region Instance Variables
        /// <summary>
        /// Instance variable for Id property.
        /// </summary>
        private string? _id { get; set; }
        #endregion

        #region Constuctors
        /// <summary>
        /// Create instance of a Document with default property values.
        /// </summary>
        public Document()
        {
        }

        /// <summary>
        /// Create instance of a Document with supplied property value(s).
        /// </summary>
        public Document(string? Id)
        {
            this.Id = Id;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Unique document identifier; to be assigned by database when document is created.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id
        {
            get
            {
                return this._id;
            }
            set
            {
                // Do a null check on the value before attempting to trim the supplied value.
                this._id = value?.Trim();

                // If this._id is not a valid Id (i.e. TryParse fails), then throw exception.
                if (!ObjectId.TryParse(this._id, out ObjectId objectId))
                {
                    throw new ArgumentException("Invalid value for Id.");
                }

                // If this._id is valid Id (i.e. not null and TryParse is successful), set the CreatedAt property to the
                // CreationTime as derived from the parsed ObjectId.
                this.CreatedAt = objectId.CreationTime;
            }
        }

        /// <summary>
        /// Document's creation date/time.
        /// </summary>
        [BsonIgnore]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime CreatedAt { get; private set; }
    }
    #endregion
}