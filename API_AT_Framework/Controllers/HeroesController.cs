using Domain.Entities;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API_AT_Framework.Controllers
{
    public class HeroesController : ControllerBase
    {
        private IHeroesService _heroesService;

        public HeroesController(IHeroesService heroesService)
        {
            _heroesService = heroesService;
        }

        public async Task<ActionResult> GetListaHeroes()
        {
            var result = await _heroesService.GetListaHeroes();
            if (result == null) return BadRequest("Lista vazia");

            return Ok(result);
        }

        public async Task<ActionResult> SalvarHeroe(Heroes heroes)
        {
            var result = await _heroesService.SalvarHeroe(heroes);
            if (result == true) return Ok("Heroe salvo na lista de favoritos");

            return BadRequest();
        }

        public async Task<ActionResult> GetDetalheHeroe(int id)
        {
            var result = await _heroesService.GetDetalhe(id);
            if (result == null) return BadRequest();

            return Ok(result);
        }

        public async Task<ActionResult> DeleteHeroe(int id)
        {
            var result = await _heroesService.DeleteHeroe(id);
            if (result == true) return Ok("Heroe removido da lista");
            return BadRequest();
        }
    }
}
