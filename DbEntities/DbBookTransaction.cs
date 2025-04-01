namespace DbEntities;

public class DbBookTransaction
{
    private readonly Guid? _id;

    public Guid Id
    {
        get => _id ?? Guid.Empty;
        init => _id = (value == Guid.Empty) ? Guid.NewGuid() : value;
    }

    public Guid BookId { get; set; }
    public Guid ReaderId { get; set; }
    public DateTime IssuedAt { get; set; }
    public DateTime? ReturnedAt { get; set; }
    public decimal AccruedFine { get; set; }
    public bool IsReturned { get; set; }
}