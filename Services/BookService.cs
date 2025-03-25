using System.Data.Common;
using DateBase;
using DbEntities;

namespace Services;

public class BookService : IBookService
{
    public Guid Create(DbBook book)
    {
        DbContext._books[book.Id] = book;
        return book.Id;
    }

    public bool Update(DbBook newBook)
    {
        if (DbContext._books.TryGetValue(newBook.Id, out _))
        {
            DbContext._books[newBook.Id] = newBook;
            return true;
        }
        return false;
    }

    public bool Delete(Guid id)
    {
        if (DbContext._books.TryGetValue(id, out _))
        {
            DbContext._books.Remove(id);
            return true;
        }
        return false;
    }

    public List<DbBook> Get() => DbContext._books.Values.ToList();

    public DbBook? Get(Guid id)
    {
        DbContext._books.TryGetValue(id, out DbBook? book);
        return book;
    }
}