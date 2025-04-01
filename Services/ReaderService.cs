using System.Data;
using DateBase;
using DbEntities;

namespace Services;

public class ReaderService : IReaderService
{
    public Guid Create(DbReader reader)
    {
        DbContext._readers[reader.Id] = reader;
        return reader.Id;
    }

    public bool Update(DbReader newReader)
    {
        if (DbContext._readers.TryGetValue(newReader.Id, out _))
        {
            DbContext._readers[newReader.Id] = newReader;
            return true;
        }
        return false;
    }

    public bool Delete(Guid id)
    {
        if (DbContext._readers.TryGetValue(id, out _))
        {
            DbContext._readers.Remove(id);
            return true;
        }
        return false;
    }

    public List<DbReader> Get() => DbContext._readers.Values.ToList();

    public DbReader? Get(Guid id)
    {
        DbContext._readers.TryGetValue(id, out DbReader? reader);
        return reader;
    }
}