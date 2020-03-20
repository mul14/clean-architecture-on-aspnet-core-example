using System;
using ExampleCleanArchitecture.Data.Dtos;
using ExampleCleanArchitecture.Domain.UseCases.Product;
using Microsoft.AspNetCore.Mvc;

namespace ExampleCleanArchitecture.Presenters.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int id)
        {
            var product = GetProductById.Handle(id);
            
            // This is should use AutoMapper on repository
            // to transform product variable above to ProductResponse.
            var response = new ProductResponse()
            {
                Id = new Guid(), 
                Name = product.Name,
                Price = product.Price,
                CreatedAt = DateTime.Today
            };
            
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Create()
        {
            // From user input
            var request = new ProductRequest()
            {
                Name = "Macbook Pro 14-inch",
                Price = 42999000
            };
            
            // Use use case at here
            var product = CreateNewProduct.Handle(request);
            
            return Ok(product);
        }
    }
}
