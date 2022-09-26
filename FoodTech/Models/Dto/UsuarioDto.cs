using System.ComponentModel.DataAnnotations;

namespace FoodTech.Models.Dto
{
    public class UsuarioDto
    {
        public string NomeUsuario { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string TipoUsuario { get; set; }
    }
}
