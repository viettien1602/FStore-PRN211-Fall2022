using DataAccess.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Services
{
    public class ProductService
    {
        private ProductRepository productRepository;

        public ProductService()
        {
            productRepository = new ProductRepository();
        }

        public List<Product> GetProducts() => productRepository.GetProducts();

        public void Update(Product product) => productRepository.Update(product);

        public void Create(Product product) => productRepository.Create(product);
        public void Delete(Product product) => productRepository.Delete(product);
    }
}
