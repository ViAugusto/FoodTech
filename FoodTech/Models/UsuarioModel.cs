using System.ComponentModel.DataAnnotations;

namespace FoodTech.Models
{
    public class UsuarioModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string NomeUsuario { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string TipoUsuario { get; set; }
    }
}
