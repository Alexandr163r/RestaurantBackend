namespace RestaurantBackend.Infrastructure.Interfaces.DB;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task<List<TEntity>> GetAllAsync();

    Task<TEntity> GetByIdAsync(Guid id);

    Task UpdateAsync(Guid id, TEntity entity);

    Task<TEntity> Insert(TEntity entity);
}