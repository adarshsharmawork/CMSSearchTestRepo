using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Data;
using ProductsAPI.Models;

namespace ProductsAPI.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductClassification _productClassification;

        public ProductsController(IProductClassification product)
        {
            _productClassification = product;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            return _productClassification.GetAllProducts();
        }

        [HttpGet("{Id}")]
        public ActionResult<Product> GetProductById(int Id)
        {
            return _productClassification.GetProductById(Id);
        }
    }
}
