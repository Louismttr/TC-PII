using AutoMapper;
using CiberCafeColibriAPI.Models.CreateDto;
using CiberCafeColibriAPI.Models.Dto;
using CiberCafeColibriAPI.Models.UpdateDto;
using CiberCafeColibriAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CiberCafeColibriAPI.Repository.IRepository;

namespace CiberCafeColibriAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ICustomerRepository _clienteRepo;
        private readonly ILogger<ClientesController> _logger;
        private readonly IMapper _mapper;

        public ClientesController(ICustomerRepository clienteRepo, ILogger<ClientesController> logger, IMapper mapper)
        {
            _clienteRepo = clienteRepo;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetClientes()
        {
            _logger.LogInformation("Obtener los Clientes");
            var ClienteList = await _clienteRepo.GetAll();
            return Ok(_mapper.Map<IEnumerable<ClienteDto>>(ClienteList));
        }
        [HttpGet("{id:int}", Name = "GetClientes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClienteDto>> GetCliente(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Cliente con Id {id}");
                return BadRequest();
            }
            var cliente = await _clienteRepo.Get(c => c.ClienteId == id);

            if (cliente == null)
            {
                _logger.LogError($"Error al traer Cliente con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<ClienteDto>(cliente));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<ClienteDto>> AddCliente([FromBody] ClienteCreateDto clienteDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _clienteRepo.Get(e => e.NombresCliente.ToLower() == clienteDto.NombresCliente.ToLower()) != null)
            {
                ModelState.AddModelError("Nombre existe", "¡El cliente con ese nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (clienteDto == null)
            {
                return BadRequest(clienteDto);
            }

            Cliente modelo = _mapper.Map<Cliente>(clienteDto);

            await _clienteRepo.Create(modelo);

            return CreatedAtRoute("GetCliente", new { id = modelo.ClienteId }, modelo);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCliente(int id, [FromBody] ClienteUpdateDto ClienteDTO)
        {
            if (ClienteDTO == null || id != ClienteDTO.ClienteId)
            {
                return BadRequest();
            }

            Cliente modelo = _mapper.Map<Cliente>(ClienteDTO);

            await _clienteRepo.Update(modelo);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCliente(int? id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var cliente = await _clienteRepo.Get(c => c.ClienteId == id);

            if (id == null)
            {
                return NotFound();
            }

            await _clienteRepo.Remove(cliente);

            return NoContent();
        }
    }
}
