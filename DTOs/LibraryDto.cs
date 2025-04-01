namespace Entities;

public record LibraryDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public Guid LocationId { get; init; }
    public List<Guid>? BooksIds { get; init; }
    public List<Guid>? LibrariansIds { get; init; }
    public List<Guid>? PublishersIds { get; init; }
    public List<Guid>? TransactionsIds { get; init; }
}