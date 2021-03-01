using Example.MyMongo.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;


namespace Example.MyMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return new List<Product>();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<Product> GetAsync(int id)
        {
            return new Product();
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task PostAsync([FromBody] Product data)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task PutAsync(int id, [FromBody] Product data)
        {
            
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
        }
    }
}
