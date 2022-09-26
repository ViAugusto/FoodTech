using AutoMapper;
using FoodTech.Data;
using FoodTech.Interface;
using FoodTech.Models;
using FoodTech.Models.Dto;
using System.Threading.Tasks;

namespace FoodTech.Services
{
    public class DonationService : IDonationService
    {
        private readonly DonationContext _data;
        private readonly IMapper _mapper;
        public DonationService(DonationContext data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        public Task GetDoacao()
        {
            throw new System.NotImplementedException();
        }

        public Task PostDoacao(DonationDto donation)
        {
            throw new System.NotImplementedException();
        }

        public Task PutDoacao(DeliverDonationDto donation)
        {
            throw new System.NotImplementedException();
        }
    }
}
