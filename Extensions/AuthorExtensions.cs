using Entities;
using DbEntities;

namespace Extensions;

public static class AuthorExtensions
{
    public static DbAuthor DtoToAuthor(this AuthorDto author) 
      => new()
      {
            Id = author.Id,
            FirstName = author.FirstName,
            LastName = author.LastName,
            Birthday = author.Birthday,
            Biography = author.Biography,
            Books = author.Books
      };

    public static AuthorDto AuthorToDto(this DbAuthor author)
      => new()
      {
            Id = author.Id,
            FirstName = author.FirstName,
            LastName = author.LastName,
            Birthday = author.Birthday,
            Biography = author.Biography,
            Books = author.Books
      };
}

