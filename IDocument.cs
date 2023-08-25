using TradingToolbox.System.Data.NoSql.Models;

namespace TradingToolbox.System.Data.NoSql.MongoDB.Models
{
    /// <summary>
    /// Base document interface for MongoDB repository implementation.
    /// </summary>
    public interface IDocument : IDocument<string>
    {
    }
}
