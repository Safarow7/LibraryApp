namespace Entities;

public record ReaderDto : BasePersonDto
{
    public static int _countReaders = 1;

    public int ReaderNumber { get; init; }
    public Guid? LocationId { get; init; }
    public DateTime RegisteredAt { get; init; }

    public List<Guid> _bookTransactions = new();
}