using ExampleCleanArchitecture.Domain.Entities;
using ExampleCleanArchitecture.Domain.Repositories;

namespace ExampleCleanArchitecture.Data.Repositories.File
{
    public class ProductRepository : IProductRepository
    {
        public Product Get(int id)
        {
            // System.IO.File.ReadLines("");
            return new Product();
        }

        public Product Save(Product product)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            // Delete line from a file
            return true;
        }
    }
}
