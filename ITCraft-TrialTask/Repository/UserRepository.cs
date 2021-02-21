using System.Collections.Generic;
using System.Threading.Tasks;
using ITCraft_TrialTask.IRepository;
using ITCraft_TrialTask.Models;
using Microsoft.EntityFrameworkCore;

namespace ITCraft_TrialTask.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {

        }

        public Task<List<User>> GetAllUsers()
        {
           return _dbSet.AsNoTracking().ToListAsync();
        }

        public Task<int> GetCount()
        {
            return _dbSet.CountAsync(active => active.Active);
        }                                                           
    }
}
