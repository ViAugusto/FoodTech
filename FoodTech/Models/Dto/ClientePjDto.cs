using System.ComponentModel.DataAnnotations;

namespace FoodTech.Models.Dto
{
    public class ClientePjDto
    {
        [Required]
        public string NomeFantasia { get; set; }
        [Required]
        public string Cnpj { get; set; }
    }
}
