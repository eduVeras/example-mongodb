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
            throw new NotImplementedException();
        }

        public Task<Product> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Product data)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product data)
        {
            throw new NotImplementedException();
        }
    }
}
