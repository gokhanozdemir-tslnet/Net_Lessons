namespace Lesson001_Middleware.Middlewares
{
    public class MyMiddleware
    {
        RequestDelegate _next;

        public MyMiddleware(RequestDelegate next) => _next = next;

        //!? To handlle request response 
        public async Task Invoke(HttpContext context)
        {
            if (!context.Response.HasStarted)
            {
                await context.Response.WriteAsync("Hello MyMiddleware");
            }
            await _next(context);
        }


    }
}
