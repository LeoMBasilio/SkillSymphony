using System.ComponentModel.DataAnnotations;

namespace SkilsSymphony.Model
{
    public class Usuarios
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Senha é obrigatório")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "O campo Email é obrigatório")]
        public string Email { get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }
    }
}