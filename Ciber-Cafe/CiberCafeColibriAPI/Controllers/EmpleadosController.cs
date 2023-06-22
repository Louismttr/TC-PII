using AutoMapper;
using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Models.CreateDto;
using CiberCafeColibriAPI.Models.Dto;
using CiberCafeColibriAPI.Models.UpdateDto;
using CiberCafeColibriAPI.Repository.IRepositorio;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CiberCafeColibriAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly IEmployeeRepository _empleadoRepo;
        private readonly ILogger<EmpleadosController> _logger;
        private readonly IMapper _mapper;

        public EmpleadosController(IEmployeeRepository empleadoRepo, ILogger<EmpleadosController> logger, IMapper mapper)
        {
            _empleadoRepo = empleadoRepo;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<EmpleadoDto>>> GetEmpleados()
        {
            _logger.LogInformation("Obtener los empleados");
            var EmpleadoList = await _empleadoRepo.GetAll();
            return Ok(_mapper.Map<IEnumerable<EmpleadoDto>>(EmpleadoList));
        }
        [HttpGet("{id:int}", Name = "GetEmpleado")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EmpleadoDto>> GetEmpleado(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Empleado con Id {id}");
                return BadRequest();
            }
            var empleado = await _empleadoRepo.Get(e => e.EmpleadoId == id);

            if (empleado == null)
            {
                _logger.LogError($"Error al traer Estudiante con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<EmpleadoDto>(empleado));
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<EmpleadoDto>> AddEmpleado([FromBody] EmpleadoCreateDto empleadoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _empleadoRepo.Get(e => e.NombresEmpleado.ToLower() == empleadoDto.NombresEmpleado.ToLower()) != null)
            {
                ModelState.AddModelError("Nombre existe", "¡El empleado con ese nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (empleadoDto == null)
            {
                return BadRequest(empleadoDto);
            }

            Empleado modelo = _mapper.Map<Empleado>(empleadoDto);

            await _empleadoRepo.Create(modelo);

            return CreatedAtRoute("GetEmpleado", new { id = modelo.EmpleadoId }, modelo);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateEmpleado(int id, [FromBody] EmpleadoUpdateDto empleadoDTO)
        {
            if (empleadoDTO == null || id != empleadoDTO.EmpleadoId)
            {
                return BadRequest();
            }

            Empleado modelo = _mapper.Map<Empleado>(empleadoDTO);

            await _empleadoRepo.Update(modelo);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteEmpleado(int? id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var empleado = await _empleadoRepo.Get(e => e.EmpleadoId == id);

            if (id == null)
            {
                return NotFound();
            }

            await _empleadoRepo.Remove(empleado);

            return NoContent();
        }
    }
}
