using System.Collections.Generic;
using System.Threading.Tasks;
using Example.MyMongo.Model;

namespace Example.MyMongo.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAsync();
        Task<Product> GetAsync(int id);
        Task InsertAsync(Product data);
        Task DeleteAsync(int id);
        Task UpdateAsync(Product data);
    }
}