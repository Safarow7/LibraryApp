using Entities;
using DbEntities;

namespace Extensions;

public static class LibraryExtensions
{
    public static DbLibrary DtoTolibrary(this LibraryDto library)
        => new()
        {
            Id = library.Id,
            Name = library.Name,
            LocationId = library.LocationId,
            BooksIds = library.BooksIds!,
            LibrariansIds = library.LibrariansIds!,
            PublishersIds = library.PublishersIds!,
            TransactionsIds = library.TransactionsIds
        };

    public static LibraryDto LibraryToDto(this DbLibrary library)
        => new()
        {
            Id = library.Id,
            Name = library.Name,
            LocationId = library.LocationId,
            BooksIds = library.BooksIds,
            LibrariansIds = library.LibrariansIds,
            PublishersIds = library.PublishersIds,
            TransactionsIds = library.TransactionsIds
        };
}