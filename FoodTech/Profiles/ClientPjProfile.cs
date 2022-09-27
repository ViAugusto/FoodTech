using AutoMapper;
using FoodTech.Models;
using FoodTech.Models.Dto;

namespace FoodTech.Profiles
{
    public class ClientPjProfile : Profile
    {
        public ClientPjProfile()
        {
            CreateMap<ClientePjDto, ClientPjModel>();
        }
    }
}
