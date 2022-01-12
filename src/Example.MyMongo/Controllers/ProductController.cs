using Example.MyMongo.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Example.MyMongo.Interfaces.Services;

namespace Example.MyMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }


        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productService.GetAsync().ConfigureAwait(false);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<Product> GetAsync(int id)
        {
            return await _productService.GetAsync(id).ConfigureAwait(false);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Product data)
        {
            await _productService.InsertAsync(data).ConfigureAwait(false);

            return Created("", data);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] Product data)
        {
            await _productService.UpdateAsync(data).ConfigureAwait(false);

            return Ok(data);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.DeleteAsync(id).ConfigureAwait(false);
            return Ok();
        }
    }
}
