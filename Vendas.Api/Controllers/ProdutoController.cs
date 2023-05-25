using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vendas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok("Ok");
        }
    }
}
