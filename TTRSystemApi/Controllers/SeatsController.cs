using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTRSystemApi.ILogic;
using TTRSystemApi.Models;

namespace TTRSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatsController : ControllerBase
    {
        private readonly ISeatLogic logic;

        public SeatsController(ISeatLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(logic.GetSeats());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var station = logic.GetSeatById(id);
            if (station == null) { return NotFound(); }
            return Ok(station);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Seat seat)
        {
            var res = logic.InsertSeat(seat);
            if (!res) { return BadRequest(); }
            return Ok(res);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Seat seat)
        {
            var res = logic.UpdateSeat(seat);
            if (!res) { return NotFound(); }
            return Ok(res);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var res = logic.DeleteSeat(id);
            if (!res) { return NotFound(); }
            return Ok(res);

        }





    }
}
