using RestaurantBackend.Core.Entities;
using RestaurantBackend.Infrastructure.Interfaces.DB;

namespace RestaurantBackend.Infrastructure.Interfaces.Services;

public interface IUserService : IBaseRepository<UserEntity>
{
    Task<UserEntity> GetByName(string name);
}