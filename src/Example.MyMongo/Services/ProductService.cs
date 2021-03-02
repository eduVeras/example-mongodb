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

        public Task<IEnumerable<Product>> GetAsync()
        {
            return _productRepository.GetAsync();
        }

        public Task<Product> GetAsync(int id)
        {
            return _productRepository.GetAsync(id);
        }

        public Task InsertAsync(Product data)
        {
            return _productRepository.InsertAsync(data);
        }

        public Task DeleteAsync(int id)
        {
            return _productRepository.DeleteAsync(id);
        }

        public async Task UpdateAsync(Product data)
        {
            if (data.Id.Equals(0))
            {
                throw new ArgumentNullException(nameof(data.Id),"Id must be informed.");
            }

            await _productRepository.UpdateAsync(data).ConfigureAwait(false);
        }
    }
}
