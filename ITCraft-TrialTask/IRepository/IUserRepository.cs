using System.Collections.Generic;
using System.Threading.Tasks;
using ITCraft_TrialTask.Models;

namespace ITCraft_TrialTask.IRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<List<User>> GetAllUsers();
        Task<int> GetCount();
    }
}
