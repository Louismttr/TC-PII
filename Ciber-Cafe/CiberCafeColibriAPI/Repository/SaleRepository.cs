using CiberCafeColibriAPI.Data;
using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Repository.IRepository;

namespace CiberCafeColibriAPI.Repository
{
    public class SaleRepository : Repository<Venta>, ISaleRepository
    {
        private readonly ColibriContext _db;

        public SaleRepository(ColibriContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Venta> Update(Venta entity)
        {
            _db.Ventas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
