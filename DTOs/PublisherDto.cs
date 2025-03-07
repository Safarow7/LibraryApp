namespase Entities;

public record PublisherDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public Guid LocationId { get; init; }
    public string Contact { get; init; } = string.Empty;
    public List<Guid> BooksLinks { get; init; } = new();
}