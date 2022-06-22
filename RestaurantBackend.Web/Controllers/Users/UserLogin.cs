using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantBackend.Web.Controllers.Users;

public class UserLogin : ControllerBase
{
    private readonly SignInManager<IdentityUser> signInManager;


    public UserLogin(SignInManager<IdentityUser> signInManager)
    {
        this.signInManager = signInManager;
    }
    
    [HttpPost("/Singin")]
    public async Task<IActionResult> Login([FromBody] RequestModel requestModel)
    {
        var resilt = await signInManager.SignInAsync();
    }

    public class RequestModel
    {
        public string Name { get; set; }
   
        public string Email { get; set; }
   
        public string Phone { get; set; }

        public string Password { get; set; }
    }
}



