namespace DbEntities;

public abstract class DbBasePerson
{
    private readonly Guid _id;

    public Guid Id
    {
        get => _id ?? Guid.Empty;
        init => _id = (value == Guid.Empty) ? Guid.NewGuid() : value;
    }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }

    public static GetFullName()
    {
        return $"{FirstName} {Lastname}";
    }
}