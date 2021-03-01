using Microsoft.Extensions.Logging;

namespace Example.MyMongo.Repositories
{
    public class ProductRepository
    {
        private readonly ILogger<ProductRepository> _logger;

        public ProductRepository(ILogger<ProductRepository> logger)
        {
            _logger = logger;
        }
    }
}
