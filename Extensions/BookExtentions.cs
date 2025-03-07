using Entities;
using DbEntities;

namespace Extensions;

public static class BookExtensions
{
    public static DbBook DtoToBook(this BookDto book)
        => new()
        {
            Id = book.Id,
            Name = book.Name,
            AuthorId = book.AuthorId,
            PublisherId = book.PublisherId,
            PublishedAt = book.PublisherAt,
            Genre = book.Genre,
            Count = book.Count
        };

    public static BookDto BookToDto(this DbBook book)
        => new()
        { 
            Id = book.Id,
            Name = book.Name,
            AuthorId = book.AuthorId,
            PublisherId = book.PublisherId,
            PublishedAt = book.PublisherAt,
            Genre = book.Genre,
            Count = book.Count           
        };
}