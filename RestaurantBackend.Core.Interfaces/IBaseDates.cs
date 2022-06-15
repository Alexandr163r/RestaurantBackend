namespace RestaurantBackend.Core.Interfaces;
public interface IBaseDates
{
    public DateTimeOffset ModifiedOn { get; set; }
    
    public DateTimeOffset CreatefiedOn { get; set; }
}