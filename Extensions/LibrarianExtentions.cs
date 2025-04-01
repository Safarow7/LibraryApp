using Entities;
using DbEntities;

namespace Extensions;

public static class LibrarianExtentions
{
    public static DbLibrarian DtoToLibrarian(this LibrarianDto librarian)
        => new()
        {
            Id = librarian.Id,
            FirstName = librarian.FirstName,
            LastName = librarian.LastName,
            Birthday = librarian.Birthday
        };

    public static LibrarianDto LibrarianToDto(this DbLibrarian librarian)
        => new()
        {
            Id = librarian.Id,
            FirstName = librarian.FirstName,
            LastName = librarian.LastName,
            Birthday = librarian.Birthday
        };
}