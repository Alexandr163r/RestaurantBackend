namespace RestaurantBackend.Core.Entities.Geo;

public class Address : BaseEntity

{
    public string Street { get; set; } = string.Empty;
    
    public string House { get; set; } = string.Empty;
    
    public string Floor { get; set; } = string.Empty;

    public Guid CityId { get; set; }
}