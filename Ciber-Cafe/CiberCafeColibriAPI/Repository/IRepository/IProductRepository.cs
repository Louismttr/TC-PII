using CiberCafeColibriAPI.Models;

namespace CiberCafeColibriAPI.Repository.IRepositorio
{
    public interface IProductRepository : IRepository<Producto>
    {
        Task<Producto> Update(Producto entity);
    }
}
