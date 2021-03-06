namespace RestaurantBackend.Core.Entities.Geo;

public class City : BaseEntity

{
    public string Name { get; set; } = string.Empty;

    public Guid RegionId { get; set; }
}