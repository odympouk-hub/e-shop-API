using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using odysseasAPI.models;


namespace odysseasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ΟdysseasDatabasecontext _dbContext;
        private readonly IConfiguration _configuration;


        public ProductController(ΟdysseasDatabasecontext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await _dbContext.Products.ToListAsync();

         
        }





    }
}
