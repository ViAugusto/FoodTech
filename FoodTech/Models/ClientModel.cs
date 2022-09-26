using System.ComponentModel.DataAnnotations;

namespace FoodTech.Models
{
    public class ClientModel
    {
        [Key]
        [Required]
        public int IdCliente { get; set; }
        public UsuarioModel UsuarioModel { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Sobrenome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Celular { get; set; }
    }
}
