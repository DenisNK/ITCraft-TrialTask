using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ITCraft_TrialTask.IRepository;
using ITCraft_TrialTask.Models;
using Microsoft.EntityFrameworkCore;

namespace ITCraft_TrialTask.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context): base(context)
        {
            
        }
        /*public Task Create(User entity)
        {
            throw new NotImplementedException();
        }*/

        public Task CreateWithImage(User entity)
        {
            throw new NotImplementedException();
        }

        /*public Task Delete(int id)
        {
            throw new NotImplementedException();
        }*/

        /*public IEnumerable<User> Get()
        {
            throw new NotImplementedException();
        }*/

        public IQueryable<User> GetAllUser()
        {
            throw new NotImplementedException();
        }

        /*public Task<User> GetById(int? id)
        {
            throw new NotImplementedException();
        }*/

        public Task GetByIdWithImage(int id, User entity)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUsercByIdWithTeamAsync(int? id)
        {
            throw new NotImplementedException();
        }

        /*public IEnumerable<User> GetWithInclude(params Expression<Func<User, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }*/

        public Task<User> MyDiscUnique(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        /*public Task Update(int id, User entity)
        {
            throw new NotImplementedException();
        }*/
    }
}
