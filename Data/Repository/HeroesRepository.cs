using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class HeroesRepository : IHeroesRepository
    {
        private AppDbContext _context;

        public HeroesRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<HeroeDetailDTO> GetListaHeroes()
        {
            var consulta = _context.Heroes.ToList();

            var listaHeroes = new List<HeroeDetailDTO>();
            foreach (var item in consulta)
            {
                listaHeroes.Add(new HeroeDetailDTO() {
                    name = item.name,
                    description = item.description,
                    image = item.image
                });
            }

            return listaHeroes;
        }

        public bool SalvarHeroe(Heroes heroes)
        {
            _context.Add(heroes);
            var sucesso = _context.SaveChanges();
            if (sucesso > 0) return true;
            return false;
        }

        public HeroeDetailDTO GetDetalhe(int id_Marvel)
        {
            var consulta = _context.Heroes.FirstOrDefault(x => x.Id_Marvel == id_Marvel);
            if (consulta == null) return null;

            return new HeroeDetailDTO()
            {
                name = consulta.name,
                description = consulta.description,
                image = consulta.image
            };
        }

        public bool DeleteHeroe(int id_Marvel)
        {
            var consulta = _context.Heroes.FirstOrDefault(x => x.Id_Marvel == id_Marvel);
            _context.Remove(consulta);
            var sucesso = _context.SaveChanges();
            if (sucesso > 0) return true;
            return false;
        }
    }
}
