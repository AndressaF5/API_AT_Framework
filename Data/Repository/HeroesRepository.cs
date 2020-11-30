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

        public List<ListFavHeroes> GetListaHeroes()
        {
            var consulta = _context.ListaFavoritos.ToList();

            var listaHeroes = new List<ListFavHeroes>();
            foreach (var item in consulta)
            {
                listaHeroes.Add(new ListFavHeroes()
                {
                    IdSuperHero = item.IdSuperHero,
                    NomeHero = item.NomeHero,
                    Imagem = item.Imagem,
                    Inteligencia = item.Inteligencia,
                    Forca = item.Forca,
                    Velocidade = item.Velocidade,
                    Durabilidade = item.Durabilidade,
                    Poder = item.Poder,
                    Combate = item.Combate,
                    Editora = item.Editora,
                    Apelido = item.Apelido,
                    IdentidadeSecreta = item.IdentidadeSecreta
                });
            }

            return listaHeroes;
        }

        public bool AdicionarHeroListaFavoritos(HeroPostDTO heroPostDTO)
        {
            var entity = new Hero();
            entity.IdSuperHero = heroPostDTO.IdSuperHero;
            entity.NomeHero = heroPostDTO.NomeHero;
            entity.Imagem = heroPostDTO.Imagem.Replace(@"\", "");
            entity.Inteligencia = heroPostDTO.Inteligencia;
            entity.Forca = heroPostDTO.Forca;
            entity.Velocidade = heroPostDTO.Velocidade;
            entity.Durabilidade = heroPostDTO.Durabilidade;
            entity.Poder = heroPostDTO.Poder;
            entity.Combate = heroPostDTO.Combate;
            entity.Editora = heroPostDTO.Editora;
            entity.Apelido = heroPostDTO.Apelido;
            entity.IdentidadeSecreta = heroPostDTO.IdentidadeSecreta;

            _context.Add(entity);
            var sucesso = _context.SaveChanges();
            if (sucesso > 0) return true;
            return false;
        }

        public HeroeDetailDTO GetDetalheHero(int idSuperHero)
        {
            var consulta = _context.ListaFavoritos.FirstOrDefault(x => x.IdSuperHero == idSuperHero);
            if (consulta == null) return null;

            return new HeroeDetailDTO()
            {
                NomeHero = consulta.NomeHero,
                Imagem = consulta.Imagem,
                Inteligencia = consulta.Inteligencia,
                Forca = consulta.Forca,
                Velocidade = consulta.Velocidade,
                Durabilidade = consulta.Durabilidade,
                Poder = consulta.Poder,
                Combate = consulta.Combate,
                Editora = consulta.Editora,
                Apelido = consulta.Apelido,
                IdentidadeSecreta = consulta.IdentidadeSecreta
            };
        }

        public bool DeleteHeroListaFavoritos(int idSuperHero)
        {
            var consulta = _context.ListaFavoritos.FirstOrDefault(x => x.IdSuperHero == idSuperHero);
            _context.Remove(consulta);
            var sucesso = _context.SaveChanges();
            if (sucesso > 0) return true;
            return false;
        }

        public bool EditarHeroListFav(int idSuperHero, EditHeroDTO obj)
        {
            var consulta = _context.ListaFavoritos.FirstOrDefault(x => x.IdSuperHero == idSuperHero);
            if (consulta == null) return false;

            consulta.NomeHero = obj.NomeHero != null ? obj.NomeHero : consulta.NomeHero;
            consulta.Inteligencia = obj.Inteligencia != null ? obj.Inteligencia : consulta.Inteligencia;
            consulta.Forca = obj.Forca != null ? obj.Forca : consulta.Forca;
            consulta.Velocidade = obj.Velocidade != null ? obj.Velocidade : consulta.Velocidade;
            consulta.Durabilidade = obj.Durabilidade != null ? obj.Durabilidade : consulta.Durabilidade;
            consulta.Poder = obj.Poder != null ? obj.Poder : consulta.Poder;
            consulta.Combate = obj.Combate != null ? obj.Combate : consulta.Combate;
            consulta.Editora = obj.Editora != null ? obj.Editora : consulta.Editora ;
            consulta.Apelido = obj.Apelido != null ? obj.Apelido : consulta.Apelido;
            consulta.IdentidadeSecreta = obj.IdentidadeSecreta != null ? obj.IdentidadeSecreta : consulta.IdentidadeSecreta;

            var sucesso = _context.SaveChanges();
            if (sucesso > 0) return true;
            return false;
        }
    }
}
