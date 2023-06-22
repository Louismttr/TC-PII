using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Repository.IRepositorio;

namespace CiberCafeColibriAPI.Repository.IRepository
{
    public interface ISaleRepository : IRepository<Venta>
    {
        Task<Venta> Update(Venta entity);
    }
}
