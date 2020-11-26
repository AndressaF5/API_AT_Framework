using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> b72603dee76b4f6392e6e6f945ddd88f7964b155

namespace Domain.Entities
{
    public class Heroes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required(ErrorMessage = "Id_Marvel obrigatório")]
        public int Id_Marvel { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
    }
}