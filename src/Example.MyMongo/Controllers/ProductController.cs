﻿using Example.MyMongo.Model;
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


        [HttpGet]
        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _productService.GetAsync().ConfigureAwait(false);
        }

        [HttpGet("{id}")]
        public async Task<Product> GetAsync(int id)
        {
            return await _productService.GetAsync(id).ConfigureAwait(false);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Product data)
        {
            await _productService.InsertAsync(data).ConfigureAwait(false);

            return Created("", data);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync([FromBody] Product data)
        {
            await _productService.UpdateAsync(data).ConfigureAwait(false);

            return Ok(data);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.DeleteAsync(id).ConfigureAwait(false);
            return Ok();
        }
    }
}
