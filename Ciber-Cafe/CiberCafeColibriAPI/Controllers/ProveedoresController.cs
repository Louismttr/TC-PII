using AutoMapper;
using CiberCafeColibriAPI.Models.CreateDto;
using CiberCafeColibriAPI.Models.Dto;
using CiberCafeColibriAPI.Models.UpdateDto;
using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CiberCafeColibriAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedoresController : ControllerBase
    {
        private readonly ISupplierRepository _proveedorRepo;
        private readonly ILogger<ProveedoresController> _logger;
        private readonly IMapper _mapper;

        public ProveedoresController(ISupplierRepository proveedorRepo, ILogger<ProveedoresController> logger, IMapper mapper)
        {
            _proveedorRepo = proveedorRepo;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProveedorDto>>> GetProveedores()
        {
            _logger.LogInformation("Obtener los proveedores");
            var proveedorList = await _proveedorRepo.GetAll();
            return Ok(_mapper.Map<IEnumerable<ProveedorDto>>(proveedorList));
        }

        [HttpGet("{id:int}", Name = "GetProveedores")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProveedorDto>> GetProveedor(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer al proveedor con Id {id}");
                return BadRequest();
            }
            var proveedor = await _proveedorRepo.Get(p => p.ProveedorId == id);

            if (proveedor == null)
            {
                _logger.LogError($"Error al traer al proveedor con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<ProveedorDto>(proveedor));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<ProveedorDto>> AddProveedor([FromBody] ProveedorCreateDto proveedorDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _proveedorRepo.Get(p => p.RUC.ToLower() == proveedorDto.RUC.ToLower()) != null)
            {
                ModelState.AddModelError("RUC existe", "¡el proveedor con ese RUC ya existe!");
                return BadRequest(ModelState);
            }

            if (proveedorDto == null)
            {
                return BadRequest(proveedorDto);
            }

            Proveedor modelo = _mapper.Map<Proveedor>(proveedorDto);

            await _proveedorRepo.Create(modelo);

            return CreatedAtRoute("GetProveedor", new { id = modelo.ProveedorId }, modelo);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProveedpr(int id, [FromBody] ProveedorUpdateDto ProveedorDTO)
        {
            if (ProveedorDTO == null || id != ProveedorDTO.ProveedorId)
            {
                return BadRequest();
            }

            Proveedor modelo = _mapper.Map<Proveedor>(ProveedorDTO);

            await _proveedorRepo.Update(modelo);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProveedor(int? id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var compra = await _proveedorRepo.Get(p => p.ProveedorId == id);

            if (id == null)
            {
                return NotFound();
            }

            await _proveedorRepo.Remove(compra);

            return NoContent();
        }
    }
}
