using RestaurantBackend.Core.Interfaces;

namespace RestaurantBackend.Core.Entities;

public class BaseEntity : BaseId, IBaseDates
{
    public DateTimeOffset ModifiedOn { get; set; }
    
    public DateTimeOffset CreatefiedOn { get; set; }
}