using System.ComponentModel.DataAnnotations;

namespace FoodTech.Models.Dto
{
    public class EnderecoDto
    {
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Complemento { get; set; }
        [Required]
        public int Cep { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Pais { get; set; }
    }
}
