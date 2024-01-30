using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTRSystemApi.ILogic;
using TTRSystemApi.Models;

namespace TTRSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IRegisterLogic logic;

        public AuthController(IRegisterLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        [Route("Register")]
        public IActionResult GetRegisteredUsers()
        {
            return Ok(logic.GetUsers());

        }

        [HttpGet]
        [Route("Register/{username}")]
        public IActionResult GetRegisteredUserByUserName([FromRoute] string username)
        {
           var user = logic.GetUserByUsername(username);
            if (user== null) { return NotFound(); }
            return Ok(user);
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult InsertUser([FromBody] User user)
        {
            var result = logic.InsertUser(user);
            if (!result) { return BadRequest(); }
            return Ok(result);
        }

        [HttpPut]
        [Route("Register")]

        public IActionResult UpdateUser([FromBody] User user)
        {
            var result = logic.UpdateUser(user);
            if (!result) { return NotFound(); }
            return Ok(result);
        }

        [HttpDelete]
        [Route("Register/{id:int}")]

        public IActionResult DeleteUser([FromRoute] int id)
        {
            var result = logic.DeleteUser(id);
            if (!result) { return NotFound(); }
            return Ok(result);
        }







    }
}
