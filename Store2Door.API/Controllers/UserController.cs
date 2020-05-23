using System;
using Store2Door.Repo;
using Store2Door.API.ViewModels;
using Store2Door.Service;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Store2Door.API.Controllers
{
    public class UserController:Controller
    {
        private readonly IUserService userService;
        private readonly IUserProfile userProfileService;

        public UserController(IUserService userService,IUserProfile userProfileService )
        {
            this.userService=userService;
            this.userProfileService=userProfileService;
        }
        
        [HttpGet]
        public async  Task<ActionResult<UserViewModel>> GetUserDetails(int Username){
            var data=await userService.GetUsers();
             return Ok(data);
        }
    }
}