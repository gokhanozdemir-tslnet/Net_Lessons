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
            await next(context);
        }
    }
}

//IMiddleware need service add
//builder.Services.AddTransient<MyMiddleware3>();

