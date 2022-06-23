using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace RestaurantBackend.Web.Controllers.Users;

public class UserLogin : ControllerBase
{
    private readonly SignInManager<IdentityUser> signInManager;
    private readonly UserManager<IdentityUser> userManager;

    public UserLogin(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
    {
        this.signInManager = signInManager;
        this.userManager = userManager;
    }

    [HttpPost("/login")]
    public async Task<IActionResult> Login([FromBody] RequestModel requestModel)
    {
        var user = await userManager.FindByNameAsync(requestModel.Name);

        if (user == null)
        {
            return BadRequest("User no found");
        }

        //var result = await signInManager.PasswordSignInAsync(user.UserName, requestModel.Password, false, false);

        var claims = new List<Claim>
        {
            new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserName)
        };
        ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType,
            ClaimsIdentity.DefaultRoleClaimType);

        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));

        return Ok("asfasfasfasa");
    }

    public class RequestModel
    {
        public string Name { get; set; }

        public string Password { get; set; }
    }
}