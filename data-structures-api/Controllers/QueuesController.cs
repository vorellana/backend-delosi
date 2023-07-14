using data_structures_api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace data_structures_api.Controllers
{

    [Route("api/v1/queues")]
    [ApiController]
    public class QueuesController : Controller
    {
        // TODO: pendiente de implementación

        [HttpPost("enqueue")]
        public IActionResult Enqueue()
        {
            var response = new
            {
                message = "Se agregó el elemento a la Cola",
                data = ""
            };

            return Ok(response);
        }

        [HttpPost("dequeue")]
        public IActionResult Dequeue()
        {
            var response = new
            {
                message = "Se quitó el elemento de la Cola",
                data = ""
            };

            return Ok(response);
        }

        [HttpPost("clear")]
        public IActionResult Clear()
        {
            var response = new
            {
                message = "Se eliminaron los elementos de la Cola",
                data = ""
            };

            return Ok(response);
        }

    }
}
