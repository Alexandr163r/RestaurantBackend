using Microsoft.AspNetCore.Mvc;
using RestaurantBackend.Infrastructure.Interfaces.Services;

namespace RestaurantBackend.Web.Controllers.Users;

public class UserGetAll : ControllerBase
{
    private readonly IUserService service;

    public UserGetAll(IUserService service)
    {
        this.service = service;
    }

    [HttpGet("/GetAll")]
    public async Task<IActionResult> Handle()
    {
        var users = await this.service.GetAllAsync();
        
        return Ok(users);
    }
}