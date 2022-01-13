using Example.MyMongo.Interfaces.Repositories;
using Example.MyMongo.Interfaces.Services;
using Example.MyMongo.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.MyMongo.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductService> _logger;

        public ProductService(IProductRepository productRepository, ILogger<ProductService> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<Product>> GetAsync()
        {
            return await _productRepository.GetAsync().ConfigureAwait(false);
        }

        public async Task<Product> GetAsync(int id)
        {
            return await _productRepository.GetAsync(id).ConfigureAwait(false);
        }

        public async Task InsertAsync(Product data)
        {
            await _productRepository.InsertAsync(data).ConfigureAwait(false);
        }

        public async Task DeleteAsync(int id)
        {
            await _productRepository.DeleteAsync(id).ConfigureAwait(false);
        }

        public async Task UpdateAsync(Product data)
        {
            if (data.Id.Equals(0))
            {
                throw new ArgumentNullException(nameof(data.Id), "Id must be informed.");
            }

            await _productRepository.UpdateAsync(data).ConfigureAwait(false);
        }
    }
}
