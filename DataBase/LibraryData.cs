using DbEntities;

namespace DbContext;

public static class DbContext
{
    public static readonly Dictionary<Guid, DbAuthor> _authors = new();

    public static readonly Dictionary<Guid, DbBook> _books = new();

    public static readonly Dictionary<Guid, DbBookTransaction> _bookTransactions = new();

    public static readonly Dictionary<Guid, DbLibrarian> _librarians = new();

    public static readonly Dictionary<Guid, DbLibrary> _library = new();

    public static readonly Dictionary<Guid, DbLocation> _locations = new();

    public static readonly Dictionary<Guid, DbPublisher> _publishers = new();

    public static readonly Dictionary<Guid, DbReader> _readers = new();
}