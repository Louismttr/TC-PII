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
    public class VentasController : ControllerBase
    {
        private readonly ISaleRepository _ventaRepo;
        private readonly ILogger<VentasController> _logger;
        private readonly IMapper _mapper;

        public VentasController(ISaleRepository ventaRepo, ILogger<VentasController> logger, IMapper mapper)
        {
            _ventaRepo = ventaRepo;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<VentaDto>>> GetVentas()
        {
            _logger.LogInformation("Obtener las Ventas");
            var ventaList = await _ventaRepo.GetAll();
            return Ok(_mapper.Map<IEnumerable<VentaDto>>(ventaList));
        }

        [HttpGet("{id:int}", Name = "GetVentas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<VentaDto>> GetVenta(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer la venta con Id {id}");
                return BadRequest();
            }
            var venta = await _ventaRepo.Get(v => v.VentasId == id);

            if (venta == null)
            {
                _logger.LogError($"Error al traer la venta con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<VentaDto>(venta));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<VentaDto>> AddVenta([FromBody] VentaCreateDto ventaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _ventaRepo.Get(v => v.SerieComprobante.ToLower() == ventaDto.SerieComprobante.ToLower()) != null)
            {
                ModelState.AddModelError("Comprobante existe", "¡la venta con ese comprobante ya existe!");
                return BadRequest(ModelState);
            }

            if (ventaDto == null)
            {
                return BadRequest(ventaDto);
            }

            Venta modelo = _mapper.Map<Venta>(ventaDto);

            await _ventaRepo.Create(modelo);

            return CreatedAtRoute("GetVenta", new { id = modelo.VentasId }, modelo);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateVenta(int id, [FromBody] VentaUpdateDto ventaDTO)
        {
            if (ventaDTO == null || id != ventaDTO.VentasId)
            {
                return BadRequest();
            }

            Venta modelo = _mapper.Map<Venta>(ventaDTO);

            await _ventaRepo.Update(modelo);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> VentaCompra(int? id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var venta = await _ventaRepo.Get(v => v.VentasId == id);

            if (id == null)
            {
                return NotFound();
            }

            await _ventaRepo.Remove(venta);

            return NoContent();
        }
    }
}