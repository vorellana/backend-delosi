using data_structures_api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace data_structures_api.Controllers
{

    [Route("api/v1/graphs")]
    [ApiController]
    public class GraphsController : Controller
    {
        // TODO: pendiente de implementación

        [HttpPost("addVertex")]
        public IActionResult AddVertex()
        {
            var response = new
            {
                message = "Se agregó el Vértice al Grafo",
                data = ""
            };

            return Ok(response);
        }

        [HttpPost("addEdge")]
        public IActionResult AddEdge()
        {
            var response = new
            {
                message = "Se agregó la Arista al Grafo",
                data = ""
            };

            return Ok(response);
        }

        [HttpPost("depthFirstSearch")]
        public IActionResult DepthFirstSearch()
        {
            var response = new
            {
                message = "Se realizó la búsqueda en profundidad en el Grafo",
                data = ""
            };

            return Ok(response);
        }

    }
}
