using AutoMapper;
using FoodTech.Models;
using FoodTech.Models.Dto;

namespace FoodTech.Profiles
{
    public class DeliverDonationProfile : Profile
    {
        public DeliverDonationProfile()
        {
            CreateMap<DeliverDonationDto, DeliverDonationModel>();
        }
    }
}
