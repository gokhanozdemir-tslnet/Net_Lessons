using Lesson003_DependencyInjection.Utils;

namespace Lesson003_DependencyInjection.Services
{
    public class GuideService : IResponseFormatter
    {
        private Guid guid = new Guid();
        public async Task Format(HttpContext context, string content)
        {
            await context.Response.WriteAsync($"Guid: {guid}\n {content}");
        }
    }
}
