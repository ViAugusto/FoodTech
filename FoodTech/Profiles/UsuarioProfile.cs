using AutoMapper;
using FoodTech.Models;
using FoodTech.Models.Dto;

namespace FoodTech.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<UsuarioDto, UsuarioModel>();
        }
    }
}
