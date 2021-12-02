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

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        /// <summary>
        /// Tüm kullanıcıları getirmek için kullanılır
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }



        /// <summary>
        /// id si verilen kullanıcıyı getirmek için kullanılır
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var users= _userService.GetUserById(id);
            if(users != null)
            {
                return Ok(users);
            }
            return NotFound();
        }

        /// <summary>
        /// Kullanıcı eklemek için kullanılır
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody]User user)
        {
                var createduser = _userService.CreateUser(user);
                return CreatedAtAction("Get", new { id = createduser.Id }, createduser);
        }

        [HttpPut]
        public IActionResult Put([FromBody]User user)
        {
            if(_userService.GetUserById(user.Id) != null)
            {
                return Ok(_userService.UpdateUser(user)); 
            }
            return NotFound();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (_userService.GetUserById(id) != null)
            {
                _userService.DeleteUser(id);
                return Ok();
            }
            return NotFound();
            
        }
    }
}
