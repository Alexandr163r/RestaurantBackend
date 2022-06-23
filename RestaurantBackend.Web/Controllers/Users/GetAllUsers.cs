using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantBackend.Infrastructure.Interfaces.Services;

namespace RestaurantBackend.Web.Controllers.Users;

public class GetAllUsers : ControllerBase
{
    private readonly IUserService service;

    public GetAllUsers(IUserService service)
    {
        this.service = service;
    }

    
    [HttpGet("get")]
    public async Task<IActionResult> Handle()
    {
        var users = await this.service.GetAllAsync();
        return Ok(users);
    }
}