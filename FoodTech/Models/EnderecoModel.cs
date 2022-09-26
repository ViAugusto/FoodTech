using System.ComponentModel.DataAnnotations;

namespace FoodTech.Models
{
    public class EnderecoModel
    {
        public UsuarioModel UsuarioModel { get; set; }
        public ClientModel ClientModel { get; set; }
        public ClientPjModel ClientPjModel { get; set; }
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
