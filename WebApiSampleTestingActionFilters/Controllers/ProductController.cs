using Microsoft.AspNetCore.Mvc;
using WebApiSampleTestingActionFilters.ActionFilters;
using WebApiSampleTestingActionFilters.Models;
using WebApiSampleTestingActionFilters.Services.Product;

namespace WebApiSampleTestingActionFilters.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return _productService.ProductsList();
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAction))]
        public IActionResult Add([FromBody] ProductModel product)
        {
            return _productService.Insert(product);
        }
    }
}
