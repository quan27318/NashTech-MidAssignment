using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BackEnd.Models;
using BackEnd.Services;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }
    [HttpGet("user/{UserId}")]
    public List<User> GetUsers(){
        return _userServices.GetUsers();
    }
    [HttpPost("user/{UserId}")]
    public HttpStatusCode CreateUser(User user){
        _userServices.CreateUser(user);
        return HttpStatusCode.OK;
    }
        
    }
}