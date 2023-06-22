using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Repository.IRepositorio;

namespace CiberCafeColibriAPI.Repository.IRepository
{
    public interface IPurchaseRepository: IRepository<Compra>
    {
        Task<Compra> Update(Compra entity);
    }
}
