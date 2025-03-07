namespace DbEntities;

public class DbLibrary
{
    private readonly Guid _id;

    public Guid Id
    {
        get => _id ?? Guid.Empty;
        init => _id = (value == Guid.Empty) ? Guid.NewGuid() : value;
    }

    public string Name { get; set; } = string.Empty;
    public Guid? LocationId { get; init; }
    public List<Guid> BooksIds { get; init; } = new();
    public List<Guid> LibrariansIds { get; init; } = new();
    public List<Guid> ReadersIds { get; init; } = new();
    public List<Guid> PublishersIds { get; init; } = new();
}