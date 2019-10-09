using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbTest.Models;
using DbTest.Service;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DbTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyPolicy")]
    public class UserController : ControllerBase
    {
        private IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            var owners = _service.User.GetAllUser();
            return owners;
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var user = _service.User.Find(id);
            if (user != null)
            {
                return Ok(user);
            }
            else
            {
                return BadRequest(user);
            }
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            bool status = _service.User.AddUser(user);
            if (status)
            {
                _service.Save();
                return Ok(user);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
        {
            var u = _service.User.UpdateUser(id,user);
            if (u!=null)
            {
                _service.Save();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool status = _service.User.DeleteUser(id);
            if (status)
            {
                _service.Save();
                return Ok(status);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
