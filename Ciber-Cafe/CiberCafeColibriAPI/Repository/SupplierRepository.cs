using CiberCafeColibriAPI.Data;
using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Repository.IRepository;

namespace CiberCafeColibriAPI.Repository
{
    public class SupplierRepository : Repository<Proveedor>, ISupplierRepository
    {
        private readonly ColibriContext _db;

        public SupplierRepository(ColibriContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Proveedor> Update(Proveedor entity)
        {
            _db.Proveedores.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
