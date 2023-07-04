using Lesson016_Filters.Controllers;
using Lesson016_Filters.Entities;
using Microsoft.AspNetCore.Mvc.Filters;
using NuGet.Protocol;

namespace Lesson016_Filters.Filters.ActionFilters
{
    public class PersonActionFilter : IActionFilter
    {
        private readonly ILogger<PersonActionFilter> _logger;

        public PersonActionFilter(ILogger<PersonActionFilter> logger)
        {
            _logger = logger;
        }

      


        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation($"{nameof(PersonActionFilter)} is OnActionExecuted method");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation($"{nameof(PersonActionFilter)} is OnActionExecuting method");
            //form param
            if (context.ActionArguments.ContainsKey("collection"))
            {
                foreach (var item in context.ActionArguments)
                {
                    var person = (item.Value as Person);
                    _logger.LogInformation(person.ToJson());
                }
            }
            //ViewwData
            PersonController controller = context .Controller as PersonController;

            _logger.LogInformation($"Viewdata {controller.ViewData["mydata"]??""}");
            
        }
    }
}
