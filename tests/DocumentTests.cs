using Moq;
using TeqBench.System.Data.NoSql.Models;

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

    [TestMethod, ExpectedException(typeof(ArgumentException))]
    public void TestInvalidIdAssignmentNull()
    {
        var mock = new Mock<Document>(MockBehavior.Strict);
        mock.Setup(doc => doc).Throws<ArgumentException>();

        IDocument doc = mock.Object;
        doc.Id = null;
    }

    [TestMethod, ExpectedException(typeof(ArgumentException))]
    public void TestInvalidIdAssignmentEmptyString() {
        var mock = new Mock<Document>(MockBehavior.Strict);
        mock.Setup(doc => doc).Throws<ArgumentException>();

        IDocument doc = mock.Object;
        doc.Id = "";
    }

    [TestMethod, ExpectedException(typeof(ArgumentException))]
    public void TestInvalidIdAssignment() {
        var mock = new Mock<Document>(MockBehavior.Strict);
        mock.Setup(doc => doc).Throws<ArgumentException>();

        IDocument doc = mock.Object;
        doc.Id = "Invalid Id";
    }
}
