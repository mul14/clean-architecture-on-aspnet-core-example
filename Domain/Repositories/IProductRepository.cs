using ExampleCleanArchitecture.Domain.Entities;

namespace ExampleCleanArchitecture.Domain.Repositories
{
    public interface IProductRepository
    {
        public Product Get(int id);
        public Product Save(Product product);
        public bool Delete(int id);
    }
}
