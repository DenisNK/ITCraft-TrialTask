using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ITCraft_TrialTask.Models;

namespace ITCraft_TrialTask.IRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> MyDiscUnique(Expression<Func<User, bool>> predicate);
        Task<User> GetUsercByIdWithTeamAsync(int? id);
        Task CreateWithImage(User entity);
        IQueryable<User> GetAllUser();
        Task GetByIdWithImage(int id, User entity);
    }
}
