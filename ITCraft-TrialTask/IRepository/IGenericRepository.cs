using System.Collections.Generic;
using System.Threading.Tasks;

namespace ITCraft_TrialTask.IRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class //, IEntity
    {
        Task<TEntity> GetById(int? id);
        IEnumerable<TEntity> Get();
        Task Update(int id, TEntity entity);
        
        //  void Save();
    }
}
