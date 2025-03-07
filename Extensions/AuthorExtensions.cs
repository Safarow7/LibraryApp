using Entities;
using DbEntities;

namespace Extensions;

public static class AuthorExtensions
{
    public static DbAuthor DtoToAuthor(this AuthorDto author) 
      => new()
      {
            Id = author.Id,
            FirstName = author.Firstname,
            LastName = author.LastName,
            Birthday = author.Birthday,
            Biograghy = author.Biography,
            Books = author.Books
      };

    public static AuthorDto AuthorToDto(this DbAuthor author)
      => new()
      {
            Id = author.Id,
            FirstName = author.Firstname,
            LastName = author.LastName,
            Birthday = author.Birthday,
            Biograghy = author.Biography,
            Books = author.Books
      };
}

