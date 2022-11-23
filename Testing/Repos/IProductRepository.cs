using System.Collections.Generic;
using Testing.Models;

namespace Testing.Repos
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
