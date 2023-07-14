using data_structures_api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace data_structures_api.Controllers
{
    [Route("api/v1/arrays")]
    [ApiController]
    public class ArraysController : Controller
    {
        // TODO: pendiente de implementación

        [HttpPost("find")]
        public IActionResult Find([FromBody] CustomArray array)
        {
            var response = new
            {
                message = "Elemento encontrado encontrado en el Array",
                data = array.Values
            };

            return Ok(response);
        }


        [HttpPost("sort")]
        public IActionResult Sort([FromBody] CustomArray array)
        {
            var response = new
            {
                message = "Array ordenado",
                data = array.Values
            };

            return Ok(response);
        }

    }
}
