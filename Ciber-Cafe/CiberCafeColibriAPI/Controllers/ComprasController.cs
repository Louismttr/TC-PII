using AutoMapper;
using CiberCafeColibriAPI.Models.CreateDto;
using CiberCafeColibriAPI.Models.Dto;
using CiberCafeColibriAPI.Models.UpdateDto;
using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Repository.IRepositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CiberCafeColibriAPI.Repository.IRepository;

namespace CiberCafeColibriAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        private readonly IPurchaseRepository _compraRepo;
        private readonly ILogger<ComprasController> _logger;
        private readonly IMapper _mapper;

        public ComprasController(IPurchaseRepository compraRepo, ILogger<ComprasController> logger, IMapper mapper)
        {
            _compraRepo = compraRepo;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CompraDto>>> GetCompras()
        {
            _logger.LogInformation("Obtener las Compras");
            var compraList = await _compraRepo.GetAll();
            return Ok(_mapper.Map<IEnumerable<CompraDto>>(compraList));
        }

        [HttpGet("{id:int}", Name = "GetCompras")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CompraDto>> GetCompra(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer la comrpa con Id {id}");
                return BadRequest();
            }
            var compra = await _compraRepo.Get(c => c.CompraId == id);

            if (compra == null)
            {
                _logger.LogError($"Error al traer la compra con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<CompraDto>(compra));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<CompraDto>> AddCompra([FromBody] CompraCreateDto compraDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _compraRepo.Get(c => c.SereiComprobante.ToLower() == compraDto.SereiComprobante.ToLower()) != null)
            {
                ModelState.AddModelError("Comprobante existe", "¡la Compra con ese comprobante ya existe!");
                return BadRequest(ModelState);
            }

            if (compraDto == null)
            {
                return BadRequest(compraDto);
            }

            Compra modelo = _mapper.Map<Compra>(compraDto);

            await _compraRepo.Create(modelo);

            return CreatedAtRoute("GetCompra", new { id = modelo.CompraId }, modelo);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCompra(int id, [FromBody] CompraUpdateDto CompraDTO)
        {
            if (CompraDTO == null || id != CompraDTO.CompraId)
            {
                return BadRequest();
            }

            Compra modelo = _mapper.Map<Compra>(CompraDTO);

            await _compraRepo.Update(modelo);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCompra(int? id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var compra = await _compraRepo.Get(c => c.CompraId == id);

            if (id == null)
            {
                return NotFound();
            }

            await _compraRepo.Remove(compra);

            return NoContent();
        }
    }
}
