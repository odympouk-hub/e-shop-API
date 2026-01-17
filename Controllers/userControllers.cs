using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using odysseasAPI.models;

namespace odysseasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ΟdysseasDatabasecontext _dbContext;
        private readonly IConfiguration _configuration;

        public UserController(ΟdysseasDatabasecontext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUser(string username,string password)
        {
            var user = await _dbContext.Odysseas_Users.AnyAsync(x => x.Username==username&& x.Password==password);

            if (!user )
                return NotFound();

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
         

            _dbContext.Odysseas_Users.Add(user);
            await _dbContext.SaveChangesAsync();

            return Ok(user);
        }
        [HttpDelete]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await _dbContext.Odysseas_Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _dbContext.Odysseas_Users.Remove(user);
            await _dbContext.SaveChangesAsync();

            return Ok(user);
        }

        [HttpPatch]
        public async Task<ActionResult<User>> UptadeUser(User user)
        {
             _dbContext.Entry(user).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return Ok(user);
        }
            
    }


}

