using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using WebApiSampleTestingActionFilters.Models;

namespace WebApiSampleTestingActionFilters.ActionFilters
{
    public class ValidationFilterAction : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var param = context.ActionArguments.SingleOrDefault(s => s.Value is ProductModel);
            if (param.Value == null)
            {
                context.Result = new BadRequestObjectResult("Product is null");
                return;
            }

            var obj = param.Value as ProductModel;
            if (string.IsNullOrEmpty(obj.Name))
            {
                context.Result = new BadRequestObjectResult("Product name is empty!");
                return;
            }
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }        
    }
}
