using CiberCafeColibriAPI.Data;
using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Repository.IRepository;

namespace CiberCafeColibriAPI.Repository
{
    public class CustomerRepository : Repository<Cliente>, ICustomerRepository
    {
        private readonly ColibriContext _db;
        public CustomerRepository(ColibriContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Cliente> Update(Cliente entity)
        {
            _db.Clientes.Update(entity);
            await _db.SaveChangesAsync();
            return entity; 
        }
    }
}