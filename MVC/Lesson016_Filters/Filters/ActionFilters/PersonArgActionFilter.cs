using Microsoft.AspNetCore.Mvc.Filters;

namespace Lesson016_Filters.Filters.ActionFilters
{
    public class PersonArgActionFilter : IActionFilter
    {
        ILogger<PersonArgActionFilter> _logger;
        private readonly string Key;
        private readonly string Value;
        public PersonArgActionFilter(ILogger<PersonArgActionFilter> logger,string key,string value)
        {
            _logger = logger;   
            Key= key;
            Value= value;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
