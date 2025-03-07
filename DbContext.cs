using DbEntities;

namespace DbContext;

public static class DbContext
{
    public static readonly Dictionaty<Guid, DbAuthor> _authors = new();

    public static readonly Dictionaty<Guid, DbBook> _books = new();

    public static readonly Dictionaty<Guid, DbBookTransaction> _bookTransactions = new();

    public static readonly Dictionaty<Guid, DbLibrarian> _librarians = new();

    public static readonly Dictionaty<Guid, DbLibrary> _library = new();

    public static readonly Dictionaty<Guid, DbLocation> _locations = new();

    public static readonly Dictionaty<Guid, DbPublisher> _publishers = new();

    public static readonly Dictionaty<Guid, DbReader> _readers = new();
}