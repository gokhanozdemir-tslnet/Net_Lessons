using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Lesson001_Middleware.Middlewares
{

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


    public static class MyMiddleware2Extensions
    {
        public static IApplicationBuilder UseMyMiddleware2(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyMiddleware2>();
        }
    }
}
