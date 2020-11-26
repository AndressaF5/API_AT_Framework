using Domain.DTO;
using Domain.Entities;
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

        public Task<List<HeroeDetailDTO>> GetListaHeroes()
        {
            return Task.FromResult(_heroesRepository.GetListaHeroes());
        }

        public Task<bool> SalvarHeroe(Heroes heroes)
        {
            return Task.FromResult(_heroesRepository.SalvarHeroe(heroes));
        }

        public Task<HeroeDetailDTO> GetDetalhe(int id_Marvel)
        {
            return Task.FromResult(_heroesRepository.GetDetalhe(id_Marvel));
        }

        public Task<bool> DeleteHeroe(int id_Marvel)
        {
            return Task.FromResult(_heroesRepository.DeleteHeroe(id_Marvel));
        }
    }
}
