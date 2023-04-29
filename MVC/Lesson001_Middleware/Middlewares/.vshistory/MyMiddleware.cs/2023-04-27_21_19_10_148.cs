namespace Lesson001_Middleware.Middlewares
{
    public class MyMiddleware
    {
        RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        => _next = next;


    }
}
