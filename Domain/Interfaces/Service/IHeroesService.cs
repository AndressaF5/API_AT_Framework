using Domain.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IHeroesService
    {
        Task<List<ListFavHeroes>> GetListaHeroes();
        Task<bool> AdicionarHeroListaFavoritos(HeroPostDTO heroPostDTO);
        Task<HeroeDetailDTO> GetDetalheHero(int idSuperHero);
        Task<bool> DeleteHeroListaFavoritos(int idSuperHero);
        Task<bool> EditarHeroListFav(int idSuperHero, EditHeroDTO obj);
    }
}
