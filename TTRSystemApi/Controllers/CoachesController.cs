using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTRSystemApi.ILogic;
using TTRSystemApi.Models;

namespace TTRSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachesController : ControllerBase
    {
        private readonly ICoachLogic logic;

        public CoachesController(ICoachLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(logic.GetCoaches());
        }

        [HttpGet]
        [Route("{name}")]
        public IActionResult GetByName([FromRoute] string name)
        {
            var station = logic.GetCoachByName(name);
            if (station == null) { return NotFound(); }
            return Ok(station);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Coach coach)
        {
            var res = logic.InsertCoach(coach);
            if (!res) { return BadRequest(); }
            return Ok(res);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Coach coach)
        {
            var res = logic.UpdateCoach(coach);
            if (!res) { return NotFound(); }
            return Ok(res);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var res = logic.DeleteCoach(id);
            if (!res) { return NotFound(); }
            return Ok(res);

        }



    }
}
