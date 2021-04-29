using System;
using System.Collections.Generic;
using ProductsAPI.Models;

namespace ProductsAPI.Data
{
    public interface IProductClassification
    {
        public List<Product> GetAllProducts();
        public Product GetProductById(int id);
    }
}
