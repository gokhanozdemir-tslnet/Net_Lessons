using System.Runtime.CompilerServices;

namespace Lesson001_Middleware.Middlewares
{
    public static class MyMiddleware3Extension
    {
        public static IApplicationBuilder UseMyMiddleware3(this IApplicationBuilder builder)
            => builder.UseMiddleware<MyMiddleware3>();
    }
}
