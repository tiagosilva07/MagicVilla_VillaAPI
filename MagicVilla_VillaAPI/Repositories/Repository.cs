using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPI.Repositories
{
    public class Repository<T>: IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> DbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            DbSet = _db.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await DbSet.AddAsync(entity);
            await SaveAsync();
        }


        public async Task DeleteAsync(T entity)
        {
            DbSet.Remove(entity);
            await SaveAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, string includeProperties = null)
        {
            IQueryable<T> query = DbSet;

            if (!tracked)
            {
                query = query.AsNoTracking();
            }

            query = QueryOptions(filter, includeProperties, query);

            return await query.FirstOrDefaultAsync();

        }


        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = DbSet;

            query = QueryOptions(filter, includeProperties, query);

            return await query.ToListAsync();
        }


        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }


        private static IQueryable<T> QueryOptions(Expression<Func<T, bool>> filter, string includeProperties, IQueryable<T> query)
        {
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

            return query;
        }
    }
}
