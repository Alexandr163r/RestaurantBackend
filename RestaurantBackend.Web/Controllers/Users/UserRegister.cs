using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestaurantBackend.Infrastructure.DB;


namespace RestaurantBackend.Web.Controllers.Users;

public class UserRegister : ControllerBase
{
    private readonly UserManager<ApplicationUser> userManager;
    private readonly SignInManager<ApplicationUser> signInManager;

    public UserRegister(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        this.userManager = userManager;
        this.signInManager = signInManager;
    }

    [HttpPost("user/register")]
    public async Task<IActionResult> Handle([FromBody] RequestModel model)
    {
        ApplicationUser user = new ApplicationUser
        {
            Id = new Guid(),
            Email = model.Email,
            UserName = model.UserName
        };
        
        var result = await userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            return Ok(user);
        }

        return BadRequest("все плохо");
    }
}

public class RequestModel
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}
