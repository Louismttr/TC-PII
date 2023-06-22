using CiberCafeColibriAPI.Data;
using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Repository.IRepository;

namespace CiberCafeColibriAPI.Repository
{
    public class PurchaseRepository : Repository<Compra>, IPurchaseRepository
    { 
        private readonly ColibriContext _db;

        public PurchaseRepository(ColibriContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Compra> Update(Compra entity)
        {
            _db.Compras.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
