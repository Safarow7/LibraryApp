namespace DbEntities;

public static class DbLibrary
{
    public static string Title { get; set; } = "Library";

    public static DbLocation? Location { get; set; }

    public static List<Guid> AuthorsIds { get; } = new();
    public static List<Guid> BooksIds { get; } = new();
    public static List<Guid> BooksTransactionIds { get; } = new();
    public static List<Guid> LibrariansIds { get; } = new();
    public static List<Guid> PublishersIds { get; } = new();
    public static List<Guid> ReadersIds { get; } = new();
}