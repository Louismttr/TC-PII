using CiberCafeColibriAPI.Data;
using CiberCafeColibriAPI.Repository.IRepositorio;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CiberCafeColibriAPI.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ColibriContext _db;
        internal DbSet<T> dbSet;

        public Repository(ColibriContext db) 
        { 
            _db = db;
            this.dbSet = db.Set<T>();
        }

        public async Task Create(T entity)
        {
            await dbSet.AddAsync(entity);
            await save();
        }

        public async Task<T> Get(Expression<Func<T, bool>>? filter = null, bool tracked = true)
        {
            IQueryable<T> query = dbSet;
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }

        public async Task Remove(T entity)
        {
            dbSet.Remove(entity);
            await save();
        }

        public async Task save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
