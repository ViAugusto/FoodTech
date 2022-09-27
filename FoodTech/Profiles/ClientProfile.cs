using AutoMapper;
using FoodTech.Models;
using FoodTech.Models.Dto;

namespace FoodTech.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<ClienteDto, ClientModel>();
            CreateMap<ClientModel, ClienteDto>();
        }
    }
}
