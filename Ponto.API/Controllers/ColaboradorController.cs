using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ponto.Application.Dtos;
using Ponto.Application.Interfaces;

namespace Ponto.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColaboradorController : Controller
    {
        private readonly IColaboradorService _colaboradorService;

        public ColaboradorController(IColaboradorService colaboradorService)
        {
            _colaboradorService = colaboradorService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var colaborador = _colaboradorService.GetAllColaboradorAsync();

                return Ok(colaborador);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar enviar o erro, ERRO: {ex.Message}");
            }
        }


        [HttpPost]
        public async Task<IActionResult> Post(ColaboradorDto model)
        {
            try
            {
                var colaborador = await _colaboradorService.AddColaborador(model);
                if (colaborador == null) return BadRequest("Nenhum Colaborador Encontrado.");

                return Ok(colaborador);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                    $"Erro ao tentar Inserir um novo Colaborador, ERRO: {ex.Message}");
            }
        }


    }
}
