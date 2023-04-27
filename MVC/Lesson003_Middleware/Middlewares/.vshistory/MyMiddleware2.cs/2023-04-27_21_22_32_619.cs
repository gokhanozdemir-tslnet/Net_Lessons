using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Lesson001_Middleware.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyMiddleware2
    {
        private readonly RequestDelegate _next;

        public MyMiddleware2(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyMiddleware2Extensions
    {
        public static IApplicationBuilder UseMyMiddleware2(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyMiddleware2>();
        }
    }
}
