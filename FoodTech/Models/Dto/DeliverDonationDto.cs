using System.ComponentModel.DataAnnotations;

namespace FoodTech.Models.Dto
{
    public class DeliverDonationDto
    {
        [Key]
        [Required]
        public int IdDoacao { get; set; }
        [Required]
        public string TipoDoacao { get; set; }
        [Required]
        public string QuantidadeDoacao { get; set; }
        [Required]
        public bool FoiPago { get; set; }
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
