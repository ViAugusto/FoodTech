using AutoMapper;
using FoodTech.Data;
using FoodTech.Interface;
using FoodTech.Models;
using FoodTech.Models.Dto;
using System.Threading.Tasks;

namespace FoodTech.Services
{
    public class ClientService : IClientService
    {
        private readonly ClientContext _data;
        private readonly IMapper _mapper;
        public ClientService(ClientContext data, IMapper mapper)
        {
            _data = data;
            _mapper = mapper;
        }

        public Task DeleteClient(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task GetClient(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task PostClient(ClienteDto client)
        {
            throw new System.NotImplementedException();
        }

        public Task PostClientPj(ClientePjDto client)
        {
            throw new System.NotImplementedException();
        }

        public Task PostEndereco(EnderecoDto endereco)
        {
            throw new System.NotImplementedException();
        }

        public Task PostUsuario(UsuarioModel usuario)
        {
            throw new System.NotImplementedException();
        }

        public Task PutClient(ClienteDto client)
        {
            throw new System.NotImplementedException();
        }

        public Task PutClientPj(ClientePjDto client)
        {
            throw new System.NotImplementedException();
        }
    }
}
