using CiberCafeColibriAPI.Data;
using CiberCafeColibriAPI.Models;
using CiberCafeColibriAPI.Repository.IRepositorio;

namespace CiberCafeColibriAPI.Repository
{
    public class ProductRepository : Repository<Producto>, IProductRepository
    {
        private readonly ColibriContext _db;

        public ProductRepository(ColibriContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Producto> Update(Producto entity)
        {
            _db.Productos.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
