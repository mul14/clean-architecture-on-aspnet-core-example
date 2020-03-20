using System;

namespace ExampleCleanArchitecture.Data.Dtos
{
    public class ProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; } = null;
    }
}
