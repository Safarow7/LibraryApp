namespace DbEntities;

public class DbAuthor : DbBasePerson
{
    public string Biography { get; set; } = string.Empty;
    public List<Guid> Books { get; set; } = new();
}