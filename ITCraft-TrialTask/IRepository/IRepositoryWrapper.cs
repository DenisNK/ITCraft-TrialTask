using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITCraft_TrialTask.IRepository
{
    public interface IRepositoryWrapper
    {
        IUserRepository UserRepo { get; }
    }
}
