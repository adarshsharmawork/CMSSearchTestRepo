using System;
using System.Collections.Generic;
using ProductsAPI.Models;

namespace ProductsAPI.Data
{
    public class MockProdData : IProductClassification
    {
        public List<Product> GetAllProducts()
        {
            List<Product> result = new List<Product>();
            for(int i=0; i<3;i++)
            {
                Product product = new Product();
                product.ProductId = i;
                product.ProductName = "test" + i;
                product.ProductCategory = "Cat" + i;
                product.ProductOwner = "IOwn" + i;
                result.Add(product);
            }
            return result;
        }

        public Product GetProductById(int id)
        {
            return new Product { ProductId = 1, ProductCategory = "newCat", ProductName = "Great Prod", ProductOwner = "Adarsh" };
        }
    }
}
