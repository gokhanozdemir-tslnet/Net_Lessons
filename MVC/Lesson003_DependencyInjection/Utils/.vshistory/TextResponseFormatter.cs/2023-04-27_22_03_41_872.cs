namespace Lesson003_DependencyInjection.Utils
{
    public class TextResponseFormatter : IResponseFormatter
    {
        private int responseCounter = 0;

        private static TextResponseFormatter? shared;

        public static TextResponseFormatter Singleton
        {
            get
            {
                if (shared == null)
                {
                    shared = new TextResponseFormatter();
                }
                return shared;
            }
        }

        public async Task Format(HttpContext context, string content)
        {
            await context.Response.WriteAsync($"Response {++responseCounter}:\n {content}");
        }
    }
}
