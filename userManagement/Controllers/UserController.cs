using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using userManagement.Service;
using userManagement.Domain;
namespace userManagement.Controllers
{
       [ApiController]
    [Route("taazaa/[controller]")]

    public class UserController:ControllerBase
    {
        IUserProfileRepository userProfileRepository;
        IUserRepository userRepository;
        public  UserController (IUserProfileRepository _userProfileRepository, IUserRepository _userRepository)
        {
            userRepository=_userRepository;
           userProfileRepository=_userProfileRepository;
        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult createAccount(UserDTO model)
        {
           User userEntity = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                AddedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                userProfile = new UserProfile
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    AddedDate = DateTime.UtcNow,
                    ModifiedDate = DateTime.UtcNow,
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString()
                }
            };
             return Ok(userRepository.InsertUser(userEntity));

        }
      
        
        
    }
}