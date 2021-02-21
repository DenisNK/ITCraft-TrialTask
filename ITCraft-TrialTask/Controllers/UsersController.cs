using System.Collections.Generic;
using System.Threading.Tasks;
using ITCraft_TrialTask.IRepository;
using Microsoft.AspNetCore.Mvc;
using ITCraft_TrialTask.Models;

namespace ITCraft_TrialTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        public UsersController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _repositoryWrapper.UserRepo.GetAllUsers();
        }

        // GET: api/Users/GetCount

        [HttpGet("GetCount")]
        public async Task<ActionResult<int>> GetCount()
        {
            return await _repositoryWrapper.UserRepo.GetCount();
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            } 
            
            await _repositoryWrapper.UserRepo.Update(id, user); 
            return NoContent();
        }
    }
}
