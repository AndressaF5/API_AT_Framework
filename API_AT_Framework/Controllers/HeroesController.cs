using Domain.Entities;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API_AT_Framework.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HeroesController : ControllerBase
    {
        private IHeroesService _heroesService;
        
        public HeroesController(IHeroesService heroesService)
        {
            _heroesService = heroesService;
        }

        [HttpGet]
        [Route("getListaHeroes")]
        public async Task<ActionResult> GetListaHeroes()
        {
            var result = await _heroesService.GetListaHeroes();
            if (result == null) return BadRequest("Lista vazia");

            return Ok(result);
        }

        [HttpPost]
        [Route("salvarHeroe")]
        public async Task<ActionResult> SalvarHeroe([FromBody] Heroes heroes)
        {
            var result = await _heroesService.SalvarHeroe(heroes);
            if (result == true) return Ok("Heroe salvo na lista de favoritos");

            return BadRequest();
        }

        [HttpGet]
        [Route("getDetalheHeroe")]
        public async Task<ActionResult> GetDetalheHeroe(int id)
        {
            var result = await _heroesService.GetDetalhe(id);
            if (result == null) return BadRequest();

            return Ok(result);
        }

        [HttpDelete]
        [Route("deleteHeroe")]
        public async Task<ActionResult> DeleteHeroe(int id)
        {
            var result = await _heroesService.DeleteHeroe(id);
            if (result == true) return Ok("Heroe removido da lista");
            return BadRequest();
        }
    }
}
