namespace Lesson003_DependencyInjection.Utils
{
    public interface IResponseFormatter
    {
        Task Format(HttpContext context, string content);
    }
}
