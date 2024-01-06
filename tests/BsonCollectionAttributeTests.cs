using System;
using TeqBench.System.Data.NoSql.Models;

namespace TeqBench.System.Data.NoSql.MongoDB.Models.Tests
{

  [TestClass]
  public class BsonCollectionAttributeTests
  {
    [TestMethod]
    public void TestConstructor()
    {
      BsonCollectionAttribute attribute = new BsonCollectionAttribute("collection name");

      Assert.AreEqual(attribute.CollectionName, "collection name");
    }
  }
}

