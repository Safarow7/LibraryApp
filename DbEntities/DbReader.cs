namespace DbEntities;

public class DbReader : DbBasePerson
{
    public static int _countReaders = 1;

    public int ReaderNumber { get; set; }
    public Guid? LocationId { get; set; }
    public DateTime RegisteredAt { get; set; }

    public List<Guid> BookTransactions = new();
}
