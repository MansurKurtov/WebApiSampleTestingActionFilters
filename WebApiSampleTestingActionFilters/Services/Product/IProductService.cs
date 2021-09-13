using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiSampleTestingActionFilters.Models;

namespace WebApiSampleTestingActionFilters.Services.Product
{
    public interface IProductService
    {
        IActionResult ProductsList();
        IActionResult Insert(ProductModel model);
        IActionResult Update(ProductModel model);
        IActionResult Delete(int productId);
    }
}
