namespace DbEntities;

public class DbPublisher
{
    private readonly Guid? _id;

    public Guid Id
    {
        get => _id ?? Guid.Empty;
        init => _id = (value == Guid.Empty) ? Guid.NewGuid() : value;
    }

    public string Name { get; set; } = string.Empty;
    public string Contact { get; set; } = string.Empty;
    public Guid? LocationId { get; set; }
    public List<Guid> Books { get; set; } = new();
}
