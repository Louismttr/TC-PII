using CiberCafeColibriAPI.Models;

namespace CiberCafeColibriAPI.Repository.IRepositorio
{
    public interface IEmployeeRepository : IRepository<Empleado>
    {
        Task<Empleado> Update(Empleado entity);
    }
}
