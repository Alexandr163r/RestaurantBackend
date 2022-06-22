using Microsoft.AspNetCore.Identity;

namespace RestaurantBackend.Infrastructure.Interfaces.Services;

public interface IUserService
{
    public Task<IdentityUser> Insert(IdentityUser user);
    
    public Task<List<IdentityUser>> GetAllAsync();
}