using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ComplyCrafter_API.Models
{
    public class CustomValidationFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context) { }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                SortedList<string, List<string>> err = new SortedList<string, List<string>>();
                foreach (var modelStateKey in context.ModelState.Keys)
                {
                    var modelStateVal = context.ModelState[modelStateKey];
                    if (modelStateVal.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                    {
                        err.Add(modelStateKey, modelStateVal.Errors.Select(e => e.ErrorMessage).ToList());
                    }
                }

                var responseObj = new
                {
                    Errors = err
                };

                context.Result = new JsonResult(responseObj)
                {
                    StatusCode = 400
                };
            }
        }
    }
}
