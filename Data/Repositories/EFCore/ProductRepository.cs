using ExampleCleanArchitecture.Domain.Entities;
using ExampleCleanArchitecture.Domain.Repositories;

namespace ExampleCleanArchitecture.Data.Repositories.EFCore
{
    public class ProductRepository : IProductRepository
    {
        public Product Get(int id)
        {
            // Fetch from database via EF Core
            // appDbContext.Products.First()
            return new Product();
        }

        public Product Save(Product product)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            // appDbContext.Delete()
            return true;
        }
    }
}
