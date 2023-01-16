using IntegraBrasilApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace IntegraBrasilApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FeriadosNacionaisController : ControllerBase
    {
        public readonly IFeriadosNacionalService _feriadosNacionalService;

        public FeriadosNacionaisController(IFeriadosNacionalService feriadosNacionalService)
        {
            _feriadosNacionalService = feriadosNacionalService;
        }

        [HttpGet("buscar/{feriadoNacional}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarFeriado([RegularExpression("^[0-9]*$")] string feriadoNacional)
        {
            var response = await _feriadosNacionalService.BuscarFeriado(feriadoNacional);
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