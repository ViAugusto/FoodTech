using System.ComponentModel.DataAnnotations;

namespace FoodTech.Models.Dto
{
    public class ClienteDto
    {
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
