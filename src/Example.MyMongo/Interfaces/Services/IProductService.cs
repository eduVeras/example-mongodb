using Example.MyMongo.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Example.MyMongo.Interfaces.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAsync();
        Task<Product> GetAsync(int id);
        Task InsertAsync(Product data);
        Task DeleteAsync(int id);
        Task UpdateAsync(Product data);
    }
}