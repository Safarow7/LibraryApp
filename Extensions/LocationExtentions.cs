using Entities;
using DbEntities;

namespace Extensions;

public static class LocationExtensions
{
    public static LocationDto LocationToDto(this DbLocation location)
        => new()
        {
            Id = location.Id,
            Street = location.Street,
            City = location.City,
            PostCode = location.PostCode,
            County = location.Country
        };

    public static DbLocation DtoToLocation(this LocationDto location)
        => new()
        {
            Id = location.Id,
            Street = location.Street,
            City = location.City,
            PostCode = location.PostCode,
            County = location.Country
        };
}