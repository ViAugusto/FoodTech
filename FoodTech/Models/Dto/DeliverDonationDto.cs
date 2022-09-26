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
    }
}
