
using data_structures_api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace data_structures_api.Controllers
{
    [Route("api/v1/matrices")]
    [ApiController]
    public class MatricesController : Controller
    {

        [HttpPost("rotation")]
        public IActionResult Rotation([FromBody] Matrix matrix)
        {
            try {
                // Verificar que la matriz sea válida
                var (isValid, errorMessage) = matrix.IsValid();

                if (!isValid)
                {
                    return StatusCode(422, errorMessage);
                }

                return Ok(new { 
                    message = "Matriz rotada correctamente",
                    data = matrix.Rotate()
                });

            }
            catch (Exception ex) {
                
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("transponse")]
        public IActionResult Transponse()
        {
            var response = new
            {
                message = "Se Transpusieron los elementos de la Matriz",
                data = ""
            };

            return Ok(response);
        }

        [HttpPost("getElement")]
        public IActionResult GetElement()
        {
            var response = new
            {
                message = "Se entrega el elemento X de la Matriz",
                data = ""
            };

            return Ok(response);
        }

    }
}
