using Entities;
using DbEntities;

namespace Extensions;

public static class PublisherExtentions
{
    public static PublisherDto PublisherToDto(this DbPublisher publisher)
        => new()
        {
            Id = publisher.Id,
            Name = publisher.Name,
            LocationId = publisher.LocationId,
            Contact = publisher.Contact,
            BookLinks = publisher.BookLinks
        };

    public static DbPublisher DtoToPublisher(this PublisherDto publisher)
        => new()
        {
            Id = publisher.Id,
            Name = publisher.Name,
            LocationId = publisher.LocationId,
            Contact = publisher.Contact,
            BookLinks = publisher.BookLinks
        };
}