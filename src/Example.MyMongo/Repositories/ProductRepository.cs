using System.Collections.Generic;
using System.Threading.Tasks;
using Example.MyMongo.Interfaces.Repositories;
using Example.MyMongo.Model;
using Microsoft.Extensions.Logging;

namespace Example.MyMongo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ILogger<ProductRepository> _logger;

        public ProductRepository(ILogger<ProductRepository> logger)
        {
            _logger = logger;
        }

        public Task<IEnumerable<Product>> GetAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task InsertAsync(Product data)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Product data)
        {
            throw new System.NotImplementedException();
        }
    }
}
