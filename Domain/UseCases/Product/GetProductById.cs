using ExampleCleanArchitecture.Domain.Repositories;

namespace ExampleCleanArchitecture.Domain.UseCases.Product
{
    public class GetProductById
    {
        private static IProductRepository _productRepository;

        public GetProductById(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public static Entities.Product Handle(int id)
        {
            return _productRepository.Get(id);
        }
    }
}
