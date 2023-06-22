using AutoMapper;
using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Models.CreateDto;
using CiberCafeColibriAPI.Models.Dto;
using CiberCafeColibriAPI.Models.UpdateDto;

namespace CiberCafeColibriAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Empleado, EmpleadoDto>().ReverseMap();
            CreateMap<Empleado, EmpleadoCreateDto>().ReverseMap();
            CreateMap<Empleado, EmpleadoUpdateDto>().ReverseMap();

            CreateMap<Producto, ProductDto>().ReverseMap();
            CreateMap<Producto, ProductCreateDto>().ReverseMap();
            CreateMap<Producto, ProductUpdateDto>().ReverseMap();

            CreateMap<Cliente, ClienteDto>().ReverseMap();
            CreateMap<Cliente, ClienteCreateDto>().ReverseMap();
            CreateMap<Cliente, ClienteUpdateDto>().ReverseMap();

            CreateMap<Proveedor, ProveedorDto>().ReverseMap();
            CreateMap<Proveedor, ProveedorCreateDto>().ReverseMap();
            CreateMap<Proveedor, ProveedorCreateDto>().ReverseMap();

            CreateMap<Compra, CompraDto>().ReverseMap();
            CreateMap<Compra, CompraCreateDto>().ReverseMap();
            CreateMap<Compra, CompraUpdateDto>().ReverseMap();

            CreateMap<Venta, VentaDto>().ReverseMap();
            CreateMap<Venta, VentaCreateDto>().ReverseMap();
            CreateMap<Venta, VentaUpdateDto>().ReverseMap();
        }
    }
}
