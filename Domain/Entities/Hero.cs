using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Hero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdSuperHero { get; set; }
        public string NomeHero { get; set; }
        public string Imagem { get; set; }
        public string Editora { get; set; }
        public string Apelido { get; set; }
        public string Inteligencia { get; set; }
        public string Forca { get; set; }
        public string Velocidade { get; set; }
        public string Durabilidade { get; set; }
        public string Poder { get; set; }
        public string Combate { get; set; }
        public string IdentidadeSecreta { get; set; }
    }
}