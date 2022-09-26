using FoodTech.Interface;
using FoodTech.Models;
using FoodTech.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FoodTech.Controllers
{
    [ApiController]
    public class ClientController : ControllerBase
    {
        #region Cadastro Cliente
        private readonly IClientService clientService;
        public ClientController(IClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpGet("consultar-cliente")]
        public Task GetClient([FromHeader] int id)
        {
            return clientService.GetClient(id);
        }

        [HttpPost("cadastrar-usuario")]
        public Task PostUsuario([FromBody] UsuarioModel usuario)
        {
            return clientService.PostUsuario(usuario);
        }

        [HttpPost("cadastrar-cliente")]
        public Task PostClient([FromBody] ClienteDto client)
        {
            return clientService.PostClient(client);
        }

        [HttpPost("cadastrar-cliente-pj")]
        public Task PostClientPj([FromBody] ClientePjDto client)
        {
            return clientService.PostClientPj(client);
        }

        [HttpPut("atualizar-cliente")]
        public Task PutClient([FromHeader] int id, [FromBody] ClienteDto client)
        {
            return clientService.PutClient(client);
        }

        [HttpPut("atualizar-cliente-pj")]
        public Task PutClientPj([FromHeader] int id, [FromBody] ClientePjDto client)
        {
            return clientService.PutClientPj(client);
        }

        [HttpDelete("deletar-cliente")]
        public Task DeleteClient([FromHeader] int id)
        {
            return clientService.DeleteClient(id);
        }

        #endregion

        #region cadastro endereço
        [HttpPost("cadastrar-endereco")]
        public Task PostEndereco([FromBody] EnderecoDto endereco)
        {
            return clientService.PostEndereco(endereco);
        }
        #endregion
    }
}
