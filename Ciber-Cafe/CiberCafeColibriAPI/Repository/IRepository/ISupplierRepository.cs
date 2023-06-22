using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Repository.IRepositorio;

namespace CiberCafeColibriAPI.Repository.IRepository
{
    public interface ISupplierRepository : IRepository<Proveedor>
    {
        Task<Proveedor> Update(Proveedor entity);
    }
}
