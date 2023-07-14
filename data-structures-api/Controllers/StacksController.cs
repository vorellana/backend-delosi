using data_structures_api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace data_structures_api.Controllers
{
    
    [Route("api/v1/stacks")]
    [ApiController]
    public class StacksController : Controller
    {
        // TODO: pendiente de implementación

        [HttpPost("push")]
        public IActionResult Push()
        {
            var response = new
            {
                message = "Se agregó el elemento en la parte superior de la Pila",
                data = ""
            };

            return Ok(response);
        }

        [HttpPost("pop")]
        public IActionResult Pop()
        {
            var response = new
            {
                message = "Se eliminó el elemento en la parte superior de la Pila",
                data = ""
            };

            return Ok(response);
        }


        [HttpPost("isEmpty")]
        public IActionResult IsEmpty()
        {
            var response = new
            {
                message = "La Pila se encuentra vacía.",
                data = ""
            };

            return Ok(response);
        }

    }
}
