namespace Entities;

public record LocationDto
{
    public Guid Id { get; init; }
    public string Street { get; init; } = string.Empty;    
    public string City { get; init; } = string.Empty;    
    public string PostCode { get; init; } = string.Empty;    
    public string Country { get; init; } = string.Empty;    
}