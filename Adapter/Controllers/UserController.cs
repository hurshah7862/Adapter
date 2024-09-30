using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLogic.Managers;
using BusinessLogic.Models;

namespace Adapter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserManager _userManager;
        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        //public async Task<IEnumerable<User>> GetAll()
        //{
        //    return await _userManager.GetAll();
        //}
        [HttpGet]
        [Route("GetAll")]
        [Consumes("application/xml", "application/json")]
        [Produces("application/xml", "application/json")]
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _userManager.GetAll();
        }
    }
}
