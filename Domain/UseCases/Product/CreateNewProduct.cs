using ExampleCleanArchitecture.Data.Dtos;
using ExampleCleanArchitecture.Domain.Repositories;

namespace ExampleCleanArchitecture.Domain.UseCases.Product
{
    public class CreateNewProduct
    {
        private static IProductRepository _productRepository;

        public CreateNewProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public static Entities.Product Handle(ProductRequest request)
        {
            // This is should use AutoMapper for simplicity
            var product = new Entities.Product()
            {
                Name = request.Name,
                Price = request.Price,
            };
                
            return _productRepository.Save(product);
        }
    }
}
