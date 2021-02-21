using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITCraft_TrialTask.IRepository;
using Microsoft.EntityFrameworkCore;

namespace ITCraft_TrialTask.Repository
{
    public class Repository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {

        protected DbContext _context;
        protected DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get()
        {
            return _dbSet.AsNoTracking().ToList();
        }
         
        public async Task<TEntity> GetById(int? id)
        {
            return await _context.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Update(int id, TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
