using FoodTech.Models;
using FoodTech.Models.Dto;
using System.Threading.Tasks;

namespace FoodTech.Interface
{
    public interface IClientService
    {
        Task GetClient(int id);
        Task PostUsuario(UsuarioModel usuario);
        Task PostClient(ClienteDto client);
        Task PostClientPj(ClientePjDto client);
        Task PutClient(ClienteDto client);
        Task PutClientPj(ClientePjDto client);
        Task DeleteClient(int id);
        Task PostEndereco(EnderecoDto endereco);
    }
}
