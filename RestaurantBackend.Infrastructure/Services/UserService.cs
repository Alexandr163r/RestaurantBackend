using Microsoft.EntityFrameworkCore;
using RestaurantBackend.Core.Entities;
using RestaurantBackend.Infrastructure.DB;
using RestaurantBackend.Infrastructure.Interfaces.Services;

namespace RestaurantBackend.Infrastructure.Services;

public class UserService : IUserService
{
    private readonly EFDDBContext context;

    public UserService(EFDDBContext context)
    {
        this.context = context;
    }

    public Task<List<UserEntity>> GetAllAsync()
    {
        return context.UserEntities.ToListAsync();
    }

    public async Task<UserEntity> GetByIdAsync(Guid id)
    {
        var user = context.UserEntities.FirstOrDefault(x => x.Id == id);
        return user;
    }

    public Task UpdateAsync(Guid id, UserEntity entity)
    {
        throw new NotImplementedException();
    }

    public async Task<UserEntity> Insert(UserEntity entity)
    {
        var userEntry = context.Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<UserEntity> GetByName(string name)
    {
        var user = context.UserEntities.FirstOrDefault(x => x.Name == name);
        return user;
    }
}
