using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly FStoreDBContext dbContext;

        public ProductRepository()
        {
            dbContext = new FStoreDBContext();
        }
        public List<Product> GetProducts() => dbContext.Products.ToList();

        public void Update(Product product)
        {
            if (product is not null)
            {
                dbContext.Update(product);
                dbContext.SaveChanges();
            }
        }
    }
}
