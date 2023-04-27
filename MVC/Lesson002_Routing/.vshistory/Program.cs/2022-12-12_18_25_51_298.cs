var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();





app.UseRouting(); //!? Route matching ekler.
#pragma warning disable ASP0014 // Suggest using top level route registrations
app.UseEndpoints(
    endpoints =>
    {
        endpoints.MapGet("routing",
            async context =>
            {
                await context.Response.WriteAsync("Request was routed");
            }
        ),

        app.MapGet("{first}/{second}/{third}", async context =>
        {
            await context.Response.WriteAsync("Request was routed\n");
            foreach (var item in context.Request.RouteValues)
            {
                await context.Response.WriteAsync($"Key:{item.Key} Value:{item.Value}");
            }
        });
    }

);
#pragma warning restore ASP0014 // Suggest using top level route registrations

app.MapGet("/", () => "Hello World!");

app.Run();
