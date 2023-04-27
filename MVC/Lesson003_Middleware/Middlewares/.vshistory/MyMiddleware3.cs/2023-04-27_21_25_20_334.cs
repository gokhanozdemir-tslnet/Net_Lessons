namespace Lesson001_Middleware.Middlewares
{
    public class MyMiddleware3 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (context.Response.HasStarted)
            {
                context.Response.WriteAsync("MyMiddleware3");
            }
            await _next(context);
        }
    }
}
