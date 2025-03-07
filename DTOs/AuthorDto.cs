namespace Entities;

public record AuthorDto : BasePersonDto
{
    public string Biography { get; init; } = string.Empty;
    public List<Guid> Books { get; init; } = new();
}