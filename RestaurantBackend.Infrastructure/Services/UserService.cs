using Microsoft.AspNetCore.Identity;
using RestaurantBackend.Core.Entities;
using RestaurantBackend.Infrastructure.Interfaces.Services;
using RestaurantBackend.Infrastructure.Model;

namespace RestaurantBackend.Infrastructure.Services;

public class UserService : IUserService
{
    private readonly UserManager<User> userManager;

    public UserService(UserManager<User> userManager)
    {
        this.userManager = userManager;
    }
    
    public async Task<UserEntity> Insert(UserEntity entity)
    {
        var user = new User()
        { 
            Name = entity.Name,
            Surname = entity.Surname,
            Email = entity.Email,
            Password = entity.Password,
            Phone = entity.Phone
        };
        var result = await userManager.CreateAsync(user);
        return entity;
    }
}
