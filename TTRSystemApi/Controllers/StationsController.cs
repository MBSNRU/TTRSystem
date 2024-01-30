using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTRSystemApi.ILogic;
using TTRSystemApi.Models;

namespace TTRSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationsController : ControllerBase
    {
        private readonly IStationLogic logic;

        public StationsController(IStationLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(logic.GetStations());
        }

        [HttpGet]
        [Route("{name}")]
        public IActionResult GetByName([FromRoute] string name)
        {
            var station = logic.GetStationByName(name);
            if (station == null) { return NotFound(); }
            return Ok(station);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Station station)
        {
            var res = logic.InsertStation(station);
            if (!res) { return BadRequest(); }
            return Ok(res);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Station station)
        {
            var res = logic.UpdateStation(station);
            if (!res) { return NotFound(); }
            return Ok(res);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id) {
            var res = logic.DeleteStation(id);
            if (!res) { return NotFound(); }
            return Ok(res);

        }





    }
}
