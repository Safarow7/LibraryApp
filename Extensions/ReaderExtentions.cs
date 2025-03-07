using Entities;
using DbEntities;

namespace Extensions;

public static class ReaderExtensions
{
    public static DbReader DtoToReader(this ReaderDto reader)
        => new()
        {
            Id = reader.Id,
            FirstName = reader.FirstName,
            LastName = reader.LastName,
            Bithday = reader.Birthday,
            ReaderNumber = reader.ReaderNumber,
            LocationId = reader.LocationId,
            RegisteredAt = reader.RegisteredAt
        };

    public static ReaderDto DtoToReader(this DbReader reader)
        => new()
        {
            Id = reader.Id,
            FirstName = reader.FirstName,
            LastName = reader.LastName,
            Bithday = reader.Birthday,
            ReaderNumber = reader.ReaderNumber,
            LocationId = reader.LocationId
        };
}