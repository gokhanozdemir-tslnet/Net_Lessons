using Microsoft.AspNetCore.Mvc.Filters;

namespace Lesson016_Filters.Filters.ActionFilters
{
    public class GlobalActionFilter : IActionFilter
    {
        private readonly ILogger<PersonActionFilter> _logger;

        public GlobalActionFilter(ILogger<PersonActionFilter> logger)
        {
            _logger = logger;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation($"Global is OnActionExecuted method");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation($"Global is OnActionExecuting method");
        }
    }
}
