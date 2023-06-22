using CiberCafeColibriAPI.Data;
using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Repository.IRepositorio;

namespace CiberCafeColibriAPI.Repository
{
    public class EmployeeRepository : Repository<Empleado>, IEmployeeRepository
    {
        private readonly ColibriContext _db;
        public EmployeeRepository(ColibriContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Empleado> Update(Empleado entity)
        {
            _db.Empleados.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
