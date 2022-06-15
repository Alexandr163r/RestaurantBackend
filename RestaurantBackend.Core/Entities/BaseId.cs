namespace RestaurantBackend.Core.Entities;

public abstract class BaseId
{
    public Guid Id { get; set; } = Guid.NewGuid();
}