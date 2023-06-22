using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Repository.IRepositorio;

namespace CiberCafeColibriAPI.Repository.IRepository
{
    public interface ICustomerRepository : IRepository<Cliente>
    {
        Task<Cliente> Update(Cliente entity);
    }
}
