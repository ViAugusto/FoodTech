using System.ComponentModel.DataAnnotations;

namespace FoodTech.Models
{
    public class DeliverDonationModel
    {
        public ClientModel ClientModel { get; set; }
        public ClientPjModel ClientPjModel { get; set; }
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
