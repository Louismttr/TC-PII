using AutoMapper;
using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Models.CreateDto;
using CiberCafeColibriAPI.Models.Dto;
using CiberCafeColibriAPI.Models.UpdateDto;
using CiberCafeColibriAPI.Repository.IRepositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CiberCafeColibriAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductRepository _productRepo;
        private readonly ILogger<ProductosController> _logger;
        private readonly IMapper _mapper;

        public ProductosController(IProductRepository empleadoRepo, ILogger<ProductosController> logger, IMapper mapper)
        {
            _productRepo = empleadoRepo;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts()
        {
            _logger.LogInformation("Obtener los productos");
            var ProductList = await _productRepo.GetAll();
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(ProductList));
        }

        [HttpGet("{id:int}", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Producto con Id {id}");
                return BadRequest();
            }
            var producto = await _productRepo.Get(e => e.ProductoId == id);

            if (producto == null)
            {
                _logger.LogError($"Error al traer Producto con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<ProductDto>(producto));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<ProductDto>> AddProduct([FromBody] ProductCreateDto productDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _productRepo.Get(e => e.Descripcion.ToLower() == productDto.Descripcion.ToLower()) != null)
            {
                ModelState.AddModelError("Nombre existe", "¡El producto con ese nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (productDto == null)
            {
                return BadRequest(productDto);
            }

            Producto modelo = _mapper.Map<Producto>(productDto);

            await _productRepo.Create(modelo);

            return CreatedAtRoute("GetProduct", new { id = modelo.ProductoId }, modelo);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProductos(int id, [FromBody] ProductUpdateDto ProductosDTO)
        {
            if (ProductosDTO == null || id != ProductosDTO.ProductoId)
            {
                return BadRequest();
            }

            Producto modelo = _mapper.Map<Producto>(ProductosDTO);

            await _productRepo.Update(modelo);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var producto = await _productRepo.Get(e => e.ProductoId == id);

            if (id == null)
            {
                return NotFound();
            }

            await _productRepo.Remove(producto);

            return NoContent();
        }
    }

}
