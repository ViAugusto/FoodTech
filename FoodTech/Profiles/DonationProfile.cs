using AutoMapper;
using FoodTech.Models;
using FoodTech.Models.Dto;

namespace FoodTech.Profiles
{
    public class DonationProfile : Profile
    {
        public DonationProfile()
        {
            CreateMap<DonationDto, DonationModel>();
            CreateMap<DonationModel, DonationDto>();
        }
    }
}
