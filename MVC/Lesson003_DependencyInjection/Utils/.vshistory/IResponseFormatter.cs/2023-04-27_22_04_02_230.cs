namespace Lesson003_DependencyInjection.Utils
{
    public interface IResponseFormatter
    {
        Task Formatter(HttpContext context, string content);
    }
}
