namespace Entities;

public record BookDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public Guid AuthorId { get; init; }
    public Guid PublisherId { get; init; }
    public DateTime PublishedAt { get; init; }
    public string Genre { get; init; } = string.Empty;
    public int Count { get; init; }
    public float Rating { get; init; }
}