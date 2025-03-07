namespace Entities;

public record BookTransactionDto
{
    public Guid Id { get; init; }
    public Guid BookId { get; init; }
    public Guid ReaderId { get; init; }
    public DateTime IssuedAt { get; init; }
    public DateTime ReturnedAt { get; init; }
    public decimal AccruedFine { get; init; }
    public bool IsReturned { get; init; }
}