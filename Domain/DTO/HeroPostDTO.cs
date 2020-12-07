using System.Collections.Generic;

namespace Domain.DTO
{
    public class HeroPostDTO
    {
        public int IdSuperHero { get; set; }
        public string NomeHero { get; set; }
        public string Imagem { get; set; }
        public string Inteligencia { get; set; }
        public string Forca { get; set; }
        public string Velocidade { get; set; }
        public string Durabilidade { get; set; }
        public string Poder { get; set; }
        public string Combate { get; set; }
        public string Editora { get; set; }
        public List<string> Apelido { get; set; }
        public string IdentidadeSecreta { get; set; }
    }
}
