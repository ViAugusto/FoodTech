using System.ComponentModel.DataAnnotations;

namespace FoodTech.Models
{
    public class ClientPjModel
    {
        [Key]
        [Required]
        public int IdClientePj { get; set; }
        public UsuarioModel UsuarioModel { get; set; }
        [Required]
        public string NomeFantasia { get; set; }
        [Required]
        public string Cnpj { get; set; }
    }
}
