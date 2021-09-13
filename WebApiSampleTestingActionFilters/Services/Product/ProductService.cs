using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiSampleTestingActionFilters.Models;

namespace WebApiSampleTestingActionFilters.Services.Product
{
    public class ProductService : IProductService
    {
        private IList<ProductModel> _products;
        public ProductService()
        {
            _products = new List<ProductModel>();
            _products.Add(new ProductModel() { Id = 1, CategoryId = 1, Name = "Product1" });
            _products.Add(new ProductModel() { Id = 2, CategoryId = 2, Name = "Product2" });
            _products.Add(new ProductModel() { Id = 3, CategoryId = 2, Name = "Product3" });
            _products.Add(new ProductModel() { Id = 4, CategoryId = 1, Name = "Product4" });
        }
        public IActionResult ProductsList()
        {
            return new OkObjectResult(_products);
        }
        public IActionResult Insert(ProductModel model)
        {
            _products.Add(model);
            return new OkObjectResult(model);
        }
        public IActionResult Update(ProductModel model)
        {
            return new OkResult();
        }
        public IActionResult Delete(int productId)
        {
            return new OkResult();
        }
    }
}
