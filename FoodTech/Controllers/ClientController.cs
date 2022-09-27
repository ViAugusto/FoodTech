using AutoMapper;
using FoodTech.Data;
using FoodTech.Models;
using FoodTech.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTech.Controllers
{
    [ApiController]
    public class ClientController : ControllerBase
    {
        #region Cadastro Cliente
        private readonly ClientContext _client;
        private readonly ClientPjContext _clientPj;
        private readonly UsuarioContext _usuario;
        private readonly IMapper _mapper;
        public ClientController(ClientContext client, ClientPjContext clientPj, UsuarioContext usuario, IMapper mapper)
        {
            _client = client;
            _clientPj = clientPj;
            _usuario = usuario;
            _mapper = mapper;
        }

        [HttpGet("consultar-cliente")]
        public IActionResult GetClient([FromHeader] int id)
        {
            ClientModel cliente = _client.ClientModel.FirstOrDefault(data => data.IdCliente == id);
            if (cliente != null)
            {
                ClienteDto clienteDto = _mapper.Map<ClienteDto>(cliente);
                return Ok(clienteDto);
            }
            return NotFound();
        }

        [HttpPost("cadastrar-usuario")]
        public IActionResult PostUsuario([FromBody] UsuarioDto usuario)
        {
            UsuarioModel usuarioModel = _mapper.Map<UsuarioModel>(usuario);
            _usuario.UsuarioModel.Add(usuarioModel);
            _usuario.SaveChanges();
            return Ok(usuarioModel);

        }

        [HttpPost("cadastrar-cliente")]
        public IActionResult PostClient([FromBody] ClienteDto client)
        {
            ClientModel cliente = _mapper.Map<ClientModel>(client);
            _client.ClientModel.Add(cliente);
            _client.SaveChanges();
            return Ok(cliente);
        }

        [HttpPost("cadastrar-cliente-pj")]
        public IActionResult PostClientPj([FromBody] ClientePjDto client)
        {
            ClientPjModel cliente = _mapper.Map<ClientPjModel>(client);
            _clientPj.ClientPjModel.Add(cliente);
            _clientPj.SaveChanges();
            return CreatedAtAction(nameof(GetClient), new { cliente.IdClientePj }, cliente);
        }

        [HttpPut("atualizar-cliente")]
        public IActionResult PutClient([FromHeader] int id, [FromBody] ClienteDto clientDto)
        {
            ClientModel cliente = _client.ClientModel.FirstOrDefault(data => data.IdCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }
            _mapper.Map(clientDto, cliente);
            return NoContent();
        }

        [HttpPut("atualizar-cliente-pj")]
        public IActionResult PutClientPj([FromHeader] int id, [FromBody] ClientePjDto clientPjDto)
        {
            ClientPjModel clientePj = _clientPj.ClientPjModel.FirstOrDefault(data => data.IdClientePj == id);
            if (clientePj == null)
            {
                return NotFound();
            }
            _mapper.Map(clientPjDto, clientePj);
            return NoContent();
        }

        [HttpDelete("deletar-cliente")]
        public IActionResult DeleteClient([FromHeader] int id)
        {
            ClientModel cliente = _client.ClientModel.FirstOrDefault(data => data.IdCliente == id);
            if (cliente == null)
            {
                return NotFound();
            }
            _client.Remove(cliente);
            return NoContent();
        }
        [HttpDelete("deletar-cliente-pj")]
        public IActionResult DeleteClientPj([FromHeader] int id)
        {
            ClientPjModel clientePj = _clientPj.ClientPjModel.FirstOrDefault(data => data.IdClientePj == id);
            if (clientePj == null)
            {
                return NotFound();
            }
            _client.Remove(clientePj);
            return NoContent();
        }

        #endregion
    }
}
