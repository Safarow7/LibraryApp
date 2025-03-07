namespace DbEntities;

public class DbBook
{
    private readonly Guid? _id;

    public Guid Id
    {
        get => _id ?? Guid.Empty;
        init => _id = (value == Guid.Empty) ? Guid.NewGuid() : value;
    }

    public string Name { get; set; } = string.Empty;
    public Guid AuthorId { get; set; }
    public Guid PublisherId { get; set; }
    public DateTime PublishedAt { get; set; }
    public string Genre { get; set; } = string.Empty;
    public int Count { get; set; }
    public float Rating { get; set; }
}