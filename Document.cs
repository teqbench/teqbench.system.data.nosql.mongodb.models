using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

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
        /// <remarks>
        /// Explicitly set the Id property to null in the constructor to
        /// ensure the CreatedAt is initialized appropriately based on the
        /// value of the Id property.
        /// </remarks>
        public Document() : this(null)
        {
            this.Id = null;
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

                // If this._id is null, then set the default value of the CreatedAt property, otherwise, if not null
                // set the CreatedAt property to the CreationTime of the document as derived from the ObjectId based
                // on the non-null value of this._id.
                this.CreatedAt = this._id is null ? DateTime.MinValue : (new ObjectId(this._id)).CreationTime;
            }
        }

        /// <summary>
        /// Document's creation date/time.
        /// </summary>
        /// <remarks>If the Id property of the instance is null, then the CreatedAt property is the <code>DateTime.MinValue</code>.</remarks>
        [BsonIgnore]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime CreatedAt { get; private set; }
    }
    #endregion
}