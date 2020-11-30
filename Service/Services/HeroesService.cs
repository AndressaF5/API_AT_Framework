using Domain.DTO;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class HeroesService : IHeroesService
    {
        private IHeroesRepository _heroesRepository;

        public HeroesService(IHeroesRepository heroesRepository)
        {
            _heroesRepository = heroesRepository;
        }

        public Task<List<ListFavHeroes>> GetListaHeroes()
        {
            return Task.FromResult(_heroesRepository.GetListaHeroes());
        }

        public Task<bool> AdicionarHeroListaFavoritos(HeroPostDTO heroPostDTO)
        {
            return Task.FromResult(_heroesRepository.AdicionarHeroListaFavoritos(heroPostDTO));
        }

        public Task<HeroeDetailDTO> GetDetalheHero(int idSuperHero)
        {
            return Task.FromResult(_heroesRepository.GetDetalheHero(idSuperHero));
        }

        public Task<bool> DeleteHeroListaFavoritos(int idSuperHero)
        {
            return Task.FromResult(_heroesRepository.DeleteHeroListaFavoritos(idSuperHero));
        }

        public Task<bool> EditarHeroListFav(int idSuperHero, EditHeroDTO obj)
        {
            return Task.FromResult(_heroesRepository.EditarHeroListFav(idSuperHero, obj));
        }
    }
}
