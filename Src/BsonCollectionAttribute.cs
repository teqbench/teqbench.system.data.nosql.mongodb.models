using System;
namespace TeqBench.System.Data.NoSql.MongoDB.Models
{
    /// <summary>
    /// Attribute to be used by domain model class implementation (i.e. class that implements the Document base
    /// class of this package) to easily identify the collection in the DB where to store the document.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class BsonCollectionAttribute : Attribute
    {
        /// <summary>
        /// The name of the collection in the DB to store a domain model class implementation (i.e. class that implements the Document base
        /// class of this package).
        /// </summary>
        public string CollectionName { get; }

        /// <summary>
        /// Attribute decorator for a domain model class implementation (i.e. class that implements the Document base
        /// class of this package).
        /// </summary>
        /// <param name="collectionName">The collection name in the DB.</param>
        public BsonCollectionAttribute(string collectionName)
        {
            CollectionName = collectionName;
        }
    }
}
