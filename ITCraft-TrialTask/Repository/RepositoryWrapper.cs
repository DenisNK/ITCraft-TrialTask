using ITCraft_TrialTask.IRepository;
using Microsoft.EntityFrameworkCore;

namespace ITCraft_TrialTask.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly DbContext _context;

        private IUserRepository _userRepository;
       
        public RepositoryWrapper(DbContext repoContext)
        {
            _context = repoContext;
        }

        public IUserRepository UserRepo
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_context);
                }

                return _userRepository;
            }
        }
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
