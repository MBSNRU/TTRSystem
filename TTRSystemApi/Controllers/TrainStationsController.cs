using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTRSystemApi.ILogic;
using TTRSystemApi.Models;

namespace TTRSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainStationsController : ControllerBase
    {
        private readonly ITrainStationLogic logic;

        public TrainStationsController(ITrainStationLogic logic)
        {
            this.logic = logic;
        }



        [HttpGet]
        public IActionResult Get()
        {
            return Ok(logic.Get());
        }

        
        [HttpPost]
        public IActionResult Insert([FromBody] TrainStation trainStation)
        {
            var res = logic.Insert(trainStation);
            if (!res) { return BadRequest(); }
            return Ok(res);
        }

        [HttpPut]
        public IActionResult Update([FromBody] TrainStation trainStation)
        {
            var res = logic.Update(trainStation);
            if (!res) { return NotFound(); }
            return Ok(res);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var res = logic.Delete(id);
            if (!res) { return NotFound(); }
            return Ok(res);

        }








    }
}
