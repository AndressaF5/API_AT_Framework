using Domain.DTO;
using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IHeroesService
    {
        Task<List<HeroeDetailDTO>> GetListaHeroes();
        Task<bool> SalvarHeroe(Heroes heroes);
        Task<HeroeDetailDTO> GetDetalhe(int id);
        Task<bool> DeleteHeroe(int id);
    }
}
