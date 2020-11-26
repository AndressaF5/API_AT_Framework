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

        public List<Heroes> ListarHeroes()
        {
            var consulta = _context.Heroes.ToList();

            var listaHeroes = new List<Heroes>();
            foreach (var item in consulta)
            {
                listaHeroes.Add(new Heroes() {
                    id = item.id,
                    name = item.name,
                    description = item.description,
                    image = item.image
                });
            }

            return listaHeroes;
        }
    }
}
