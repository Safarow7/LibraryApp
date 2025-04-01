using DateBase;
using DbEntities;

namespace Services;

public class LibrarianService : ILibrarianService
{
    public Guid Create(DbLibrarian librarian)
    {
        DbContext._librarians[librarian.Id] = librarian;
        return librarian.Id;
    }

    public bool Update(DbLibrarian newLibrarian)
    {
        if (DbContext._librarians.TryGetValue(newLibrarian.Id, out _))
        {
            DbContext._librarians[newLibrarian.Id] = newLibrarian;
            return true;
        }
        return false;
    }

    public bool Delete(Guid id)
    {
        if (DbContext._librarians.TryGetValue(id, out _))
        {
            DbContext._librarians.Remove(id);
            return true;
        }
        return false;
    }

    public List<DbLibrarian> Get() => DbContext._librarians.Values.ToList();

    public DbLibrarian? Get(Guid id)
    {
        DbContext._librarians.TryGetValue(id, out DbLibrarian? librarian);
        return librarian;
    }
}