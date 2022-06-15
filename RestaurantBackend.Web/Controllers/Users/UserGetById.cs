using Microsoft.AspNetCore.Mvc;
using RestaurantBackend.Infrastructure.Interfaces.Services;

namespace RestaurantBackend.Web.Controllers.Users;

public class UserGetById : ControllerBase

{
    private readonly IUserService service;

    public UserGetById(IUserService service)
    {
        this.service = service;
    }

    [HttpGet("/{id;guid}")]
    public async Task<IActionResult> Handle(Guid id)
    {
        var users = await this.service.GetByIdAsync(id);
        
        return Ok(users);
    }
}