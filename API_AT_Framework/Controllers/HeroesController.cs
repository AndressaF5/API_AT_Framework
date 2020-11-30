using Domain.DTO;
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
        [Route("adicionarHeroNaListaFavoritos")]
        public async Task<ActionResult> AdicionarHeroListaFavoritos([FromBody] HeroPostDTO heroPostDTO)
        {
            var result = await _heroesService.AdicionarHeroListaFavoritos(heroPostDTO);
            if (result == true) return Ok("Hero salvo na lista de favoritos");

            return BadRequest();
        }

        [HttpGet]
        [Route("getDetalheHero")]
        public async Task<ActionResult> GetDetalheHero(int id)
        {
            var result = await _heroesService.GetDetalheHero(id);
            if (result == null) return BadRequest();

            return Ok(result);
        }

        [HttpDelete]
        [Route("deleteHeroListaFavoritos")]
        public async Task<ActionResult> DeleteHeroListaFavoritos(int id)
        {
            var result = await _heroesService.DeleteHeroListaFavoritos(id);
            if (result == true) return Ok("Hero removido da lista");
            return BadRequest();
        }

        [HttpPost]
        [Route("editarHeroListFav")]
        public async Task<ActionResult> EditarHeroListFav(int idSuperHero, [FromBody] EditHeroDTO obj)
        {
            var result = await _heroesService.EditarHeroListFav(idSuperHero, obj);
            if (result == false) return BadRequest();
            return Ok("Heroi editado");
        }
    }
}
