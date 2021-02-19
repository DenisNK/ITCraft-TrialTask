using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ITCraft_TrialTask.IRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class //, IEntity
    {
        Task Create(TEntity entity);
        Task<TEntity> GetById(int? id);
        IEnumerable<TEntity> Get();
        Task Delete(int id);
        Task Update(int id, TEntity entity);
        IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties);

        //  void Save();
    }
}
