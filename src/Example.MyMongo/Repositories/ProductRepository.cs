using Example.MyMongo.Interfaces.Repositories;
using Example.MyMongo.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.MyMongo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ILogger<ProductRepository> _logger;
        private readonly string ProductCollectionName = "Products";
        private readonly string DatabaseName = "ProductsDb";
        private readonly IMongoCollection<Product> _products;
        public ProductRepository(ILogger<ProductRepository> logger, IConfiguration configuration)
        {
            _logger = logger;

            var client = new MongoClient(configuration.GetConnectionString("ProductsConnectionString"));
            var database = client.GetDatabase(DatabaseName);           
            _products = database.GetCollection<Product>(ProductCollectionName);
        }

        public async Task<IEnumerable<Product>> GetAsync()
        {
            return (await _products.FindAsync(p => true).ConfigureAwait(false)).ToList();
        }

        public async Task<Product> GetAsync(int id)
        {
            return (await _products.FindAsync<Product>(p => p.Id == id).ConfigureAwait(false)).FirstOrDefault();
        }

        public async Task InsertAsync(Product data)
        {
            await _products.InsertOneAsync(data).ConfigureAwait(false);
        }

        public async Task DeleteAsync(int id)
        {
            var deleteResult = await _products.DeleteOneAsync(p => p.Id == id).ConfigureAwait(false);
        }

        public async Task UpdateAsync(Product data)
        {
            var replaceResult = await _products.ReplaceOneAsync(p => p.Id == data.Id, data).ConfigureAwait(false);
        }
    }
}
