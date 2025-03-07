using Entities;
using DbEntities;

namespace Extensions;

public static class LibraryExtensions
{
    public static Dblibrary DtoTolibrary(this LibraryDto library)
        => new()
        {
            Id = library.Id,
            Name = library.Name,
            Location = library.Location,
            BooksIds = library.BooksIds,
            LibrariansIds = library.LibrariansIds,
            PublishersIds = library.PublishersIds,
            TransactionsIds = library.TransactionsIds
        };

    public static LibraryDto LibraryToDto(this Dblibrary library)
        => new()
        {
            Id = library.Id,
            Name = library.Name,
            Location = library.Location,
            BooksIds = library.BooksIds,
            LibrariansIds = library.LibrariansIds,
            PublishersIds = library.PublishersIds,
            TransactionsIds = library.TransactionsIds
        };
}