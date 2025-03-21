using DateBase;
using DbEntities;

namespace Services;

public class AuthorService : IAuthorService
{
    public Guid Create(DbAuthor author)
    {
        DbContext._authors[author.Id] = author;
        return author.Id;
    }

    public bool Update(DbAuthor newAuthor)
    {
        if (DbContext._authors.TryGetValue(newAuthor.Id, out _))
        {
            DbContext._authors[newAuthor.Id] = newAuthor;
            return true;
        }
        return false;
    }

    public bool Delete(Guid id)
    {
        if (DbContext._authors.TryGetValue(id, out _))
        {
            DbContext._authors.Remove(id);
            return true;
        }
        return false;
    }

    public List<DbAuthor> Get() => DbContext._authors.Values.ToList();

    public DbAuthor? Get(Guid id)
    {
        DbContext._authors.TryGetValue(id, out DbAuthor? author);

        return author;
    }
}

