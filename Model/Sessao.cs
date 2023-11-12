using System.ComponentModel.DataAnnotations;

namespace SkilsSymphony.Model
{
    public class Sessao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int IdUsuario { get; set; }

    }
}
