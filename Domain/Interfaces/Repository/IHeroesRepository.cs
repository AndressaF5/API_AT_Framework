using Domain.DTO;
using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces.Repository
{
    public interface IHeroesRepository
    {
        List<HeroeDetailDTO> GetListaHeroes();
        bool SalvarHeroe(Heroes heroes);
        HeroeDetailDTO GetDetalhe(int id);
        bool DeleteHeroe(int id);
    }
}
