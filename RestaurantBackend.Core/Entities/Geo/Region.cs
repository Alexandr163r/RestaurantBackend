namespace RestaurantBackend.Core.Entities.Geo;

public class Region : BaseEntity

{
    public string Name { get; set; } = String.Empty;

    public Guid CountryId { get; set; }
}
