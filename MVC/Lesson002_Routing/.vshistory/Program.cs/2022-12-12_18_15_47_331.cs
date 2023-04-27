var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();





app.UseRouting(); //!? Route matching ekler.
app.UseEndpoints(
    endpoints =>
    endpoints.MapGet("routing",
        async context =>
        {
            await context.Response.WriteAsync("Request was routed");
        }
    )
);

app.MapGet("/", () => "Hello World!");

app.Run();
