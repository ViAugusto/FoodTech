using FoodTech.Models;
using FoodTech.Models.Dto;
using System.Threading.Tasks;

namespace FoodTech.Interface
{
    public interface IDonationService
    {
        Task PostDoacao(DonationDto donation);
        Task GetDoacao();
        Task PutDoacao(DeliverDonationDto donation);
    }
}
