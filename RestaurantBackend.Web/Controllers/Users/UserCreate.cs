using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestaurantBackend.Infrastructure.Interfaces.Services;


namespace RestaurantBackend.Web.Controllers.Users;

public class UserCreate : ControllerBase
{
   private readonly IUserService service;
   
   public UserCreate(IUserService service)
   {
      this.service = service;
   }
   
   [HttpPost("/create")]
   public async Task<IActionResult> Handle([FromBody] RequestModel requestModel)
   {
      var user = new IdentityUser();
      user.Email = requestModel.Email;
      user.UserName = requestModel.Name;
      user.PhoneNumber = requestModel.Phone;
      user.PasswordHash = requestModel.Password;
      await service.Insert(user);
      return Ok(user);
   }
}

public class RequestModel
{
   public string Name { get; set; }
   
   public string Email { get; set; }
   
   public string Phone { get; set; }

   public string Password { get; set; }
}
