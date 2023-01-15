using System.Net;
using IntegraBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBrasilApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CnpjController : ControllerBase
    {
        public readonly ICnpjService _cnpjService;
        public CnpjController(ICnpjService cnpjService)
        {
            _cnpjService = cnpjService;
        }

        [HttpGet("buscar/{cnpj}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarCnpj([FromRoute] string cnpj)
        {
            var response = await _cnpjService.BuscaCnpj(cnpj);
            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}
