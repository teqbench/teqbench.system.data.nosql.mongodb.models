using TeqBench.System.Data.NoSql.Models;

namespace TeqBench.System.Data.NoSql.MongoDB.Models
{
    /// <summary>
    /// Base document interface for MongoDB repository implementation.
    /// </summary>
    public interface IDocument : IDocument<string?>
    {
    }
}
