using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TTRSystemApi.ILogic;
using TTRSystemApi.Models;

namespace TTRSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentLogic logic;

        public PaymentsController(IPaymentLogic logic)
        {
            this.logic = logic;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(logic.GetPaymentList());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var res = logic.GetPaymentById(id);
            if (res == null) { return NotFound(); }
            return Ok(res);
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Payment payment)
        {
            var res = logic.InsertPayment(payment);
            if (!res) { return BadRequest(); }
            return Ok(res);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Payment payment)
        {
            var res = logic.UpdatePayment(payment);
            if (!res) { return NotFound(); }
            return Ok(res);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var res = logic.DeletePayment(id);
            if (!res) { return NotFound(); }
            return Ok(res);

        }




    }
}
