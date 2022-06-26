using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantBackend.Infrastructure.DB;


namespace RestaurantBackend.Web.Controllers.Users;

public class GetAllUsers : ControllerBase
{
    private readonly SignInManager<ApplicationUser> signInManager;
    private readonly UserManager<ApplicationUser> userManager;

    public GetAllUsers(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
    {
        this.signInManager = signInManager;
        this.userManager = userManager;
    }
    
    [Authorize]
    [HttpGet("get")]
    public async Task<IActionResult> Handle()
    {
        var users = await this.userManager.Users.ToListAsync();
        return Ok(users);
    }
}
