using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestaurantBackend.Infrastructure.Interfaces.Services;
using RestaurantBackend.Infrastructure.Model;

namespace RestaurantBackend.Infrastructure.Services;

public class UserService : IUserService
{
    private readonly UserManager<IdentityUser> userManager;

    public UserService(UserManager<IdentityUser> userManager)
    {
        this.userManager = userManager;
    }

    public async Task<IdentityUser> Insert(IdentityUser entity)
    {
        var user = new User()
        {
            UserName = entity.UserName,
            Email = entity.Email,
            PhoneNumber = entity.PhoneNumber,
            Password = entity.PasswordHash
        };
        var result = await userManager.CreateAsync(user);
        return entity;
    }

    public async Task<List<IdentityUser>> GetAllAsync()
    {
        var users = await userManager.Users.ToListAsync();

        return users;
    }
}