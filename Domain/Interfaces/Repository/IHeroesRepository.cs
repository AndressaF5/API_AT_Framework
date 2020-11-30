using Domain.DTO;
using System.Collections.Generic;

namespace Domain.Interfaces.Repository
{
    public interface IHeroesRepository
    {
        List<ListFavHeroes> GetListaHeroes();
        bool AdicionarHeroListaFavoritos(HeroPostDTO heroPostDTO);
        HeroeDetailDTO GetDetalheHero(int idSuperHero);
        bool DeleteHeroListaFavoritos(int idSuperHero);
        bool EditarHeroListFav(int idSuperHero, EditHeroDTO obj);
    }
}
