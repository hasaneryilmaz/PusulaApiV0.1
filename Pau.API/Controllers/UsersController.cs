using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pau.Business.Abstract;
using Pau.Business.Concrete;
using Pau.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pau.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private IUserService _userService;

        public UsersController()
        {
            _userService = new UserManager();
        }

        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAllUsers();
        }


        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetUserById(id);
        }
    }
}
