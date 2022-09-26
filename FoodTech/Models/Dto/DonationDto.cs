using System.ComponentModel.DataAnnotations;

namespace FoodTech.Models.Dto
{
    public class DonationDto
    {
        [Required]
        public string TipoDoacao { get; set; }
        [Required]
        public string QuantidadeDoacao { get; set; }
    }
}
