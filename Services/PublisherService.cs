using DateBase;
using DbEntities;

namespace Services;

public class PublisherService : IPublisherService
{
    public Guid Create(DbPublisher publisher)
    {
        DbContext._publishers[publisher.Id] = publisher;
        return publisher.Id;
    }

    public bool Delete(Guid id)
    {
        if (DbContext._publishers.TryGetValue(id, out _))
        {
            DbContext._publishers.Remove(id);
            return true;
        }
        return false;
    }

    public bool Update(DbPublisher newPublisher)
    {
        if (DbContext._publishers.TryGetValue(newPublisher.Id, out _))
        {
            DbContext._publishers[newPublisher.Id] = newPublisher;
            return true;
        }
        return false;
    }

    public List<DbPublisher> Get() => DbContext._publishers.Values.ToList();

    public DbPublisher? Get(Guid id)
    {
        DbContext._publishers.TryGetValue(id, out DbPublisher? publisher);
        return publisher;
    }
}
