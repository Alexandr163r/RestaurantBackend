using Microsoft.AspNetCore.Mvc;
using RestaurantBackend.Core.Entities;
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
      var user = new UserEntity();
      user.Name = requestModel.Name;
      user.Surname = requestModel.Surname;
      user.Phone = requestModel.Phone;

      await this.service.Insert(user);
      return Ok(user);
   }
}

public class RequestModel
{
   public string Name { get; set; }

   public string Surname { get; set; }
    
   public string Phone { get; set; }
}
