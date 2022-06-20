using RestaurantBackend.Core.Entities;

namespace RestaurantBackend.Infrastructure.Interfaces.Services;

public interface IUserService
{
    public Task<UserEntity> Insert(UserEntity user);
}