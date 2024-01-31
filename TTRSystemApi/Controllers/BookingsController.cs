using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTRSystemApi.ILogic;
using TTRSystemApi.Models;

namespace TTRSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingLogic logic;

        public BookingsController(IBookingLogic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(logic.GetBookings());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var station = logic.GetBookingById(id);
            if (station == null) { return NotFound(); }
            return Ok(station);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Booking booking)
        {
            var res = logic.InsertBooking(booking);
            if (!res) { return BadRequest(); }
            return Ok(res);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Booking booking)
        {
            var res = logic.UpdateBooking(booking);
            if (!res) { return NotFound(); }
            return Ok(res);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var res = logic.DeleteBooking(id);
            if (!res) { return NotFound(); }
            return Ok(res);

        }



    }
}
