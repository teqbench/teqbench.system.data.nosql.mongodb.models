using Moq;

using TeqBench.System.Data.NoSql.MongoDB.Models;

namespace TeqBench.System.Data.NoSql.MongoDB.Models.Tests;

[TestClass]
public class DocumentTests
{
    [TestMethod]
    public void TestPropertyDefaults()
    {
        var mock = new Mock<Document>();
        mock.SetupAllProperties();

        IDocument doc = mock.Object;
        Assert.IsNull(doc.Id);
        Assert.AreEqual(doc.CreatedAt, DateTime.MinValue);
    }

    [TestMethod]
    public void TestId()
    {
        var mock = new Mock<Document>("64c0a0ab8e22874a66eadb4c");

        IDocument doc = mock.Object;
        Assert.AreEqual(doc.Id, "64c0a0ab8e22874a66eadb4c");
    }

    [TestMethod]
    public void TestCreatedAt()
    {
        var mock = new Mock<Document>("64c0a0ab8e22874a66eadb4c");

        IDocument doc = mock.Object;
        Assert.AreNotEqual(doc.CreatedAt, DateTime.MinValue);
    }
}
