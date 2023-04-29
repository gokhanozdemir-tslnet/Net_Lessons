namespace Lesson003_DependencyInjection.Utils
{
    public class HtmlResponseFormatter : IResponseFormatter
    {
        public async Task Formatter(HttpContext context, string content)
        {
            context.Response.ContentType = "text/html";
            await context.Response.WriteAsync($@"
                <!DOCTYPE html>
                    <html lang=""en"">
                        <head><title>Response</title></head>
                        <body>
                            <h2>Formatter Response</h2>
                            <span>{context}</span>
                        </body>
                </html>
            ");
        }
    }
}
