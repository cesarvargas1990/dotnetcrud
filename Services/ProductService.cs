using MyApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyApi.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new();

        public List<Product> GetAll() => _products;

        public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public Product Add(Product product)
        {
            product.Id = _products.Count > 0 ? _products.Max(p => p.Id) + 1 : 1;
            _products.Add(product);
            return product;
        }

        public bool Update(Product product)
        {
            var existing = GetById(product.Id);
            if (existing is null) return false;

            existing.Name = product.Name;
            existing.Price = product.Price;
            return true;
        }

        public bool Delete(int id)
        {
            var product = GetById(id);
            if (product is null) return false;

            _products.Remove(product);
            return true;
        }
    }
}
