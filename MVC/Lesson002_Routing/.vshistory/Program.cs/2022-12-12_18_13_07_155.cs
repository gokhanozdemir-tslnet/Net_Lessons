var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();





app.UseRouting(); //!? Route matching ekler.
app.UseEndpoints(
    endpoints =>
    async context =>
    {
        awaitcontext.Response.WriteAsync("Request was Routed")
    }
);

app.MapGet("/", () => "Hello World!");

app.Run();
