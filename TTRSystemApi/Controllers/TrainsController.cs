using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTRSystemApi.ILogic;
using TTRSystemApi.Models;

namespace TTRSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainsController : ControllerBase
    {
        private readonly ITrainLogic logic;

        public TrainsController(ITrainLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(logic.GetTrains());
        }

        [HttpGet]
        [Route("{number:int}")]
        public IActionResult GetByNumber([FromRoute] int number)
        {
            var station = logic.GetTrainByNumber(number);
            if (station == null) { return NotFound(); }
            return Ok(station);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Train train)
        {
            var res = logic.InsertTrain(train);
            if (!res) { return BadRequest(); }
            return Ok(res);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Train train)
        {
            var res = logic.UpdateTrain(train);
            if (!res) { return NotFound(); }
            return Ok(res);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var res = logic.DeleteTrain(id);
            if (!res) { return NotFound(); }
            return Ok(res);

        }





    }
}
