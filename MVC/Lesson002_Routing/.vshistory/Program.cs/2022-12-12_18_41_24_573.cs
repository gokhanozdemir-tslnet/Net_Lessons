var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();





app.UseRouting(); //!? Route matching ekler.
#pragma warning disable ASP0014 // Suggest using top level route registrations
app.UseEndpoints(
    endpoints =>
    {
        //? ******Biricinci Route***************************************/
        endpoints.MapGet("routing",
            async context =>
            {
                await context.Response.WriteAsync("Request was routed");
            }
        );
        //? ******end of Biricinci Route***************************************/
        //? ******ikinci Route***************************************/
        app.MapGet("{first}/{second}/{third}", async context =>
        {
            await context.Response.WriteAsync("Request was routed\n");
            foreach (var item in context.Request.RouteValues)
            {
                await context.Response.WriteAsync($"Key:{item.Key} - Value:{item.Value} \n");
            }
        });
        //? ******Biricinci Route***************************************/
        //? ******üçüncü Route***************************************/
        //matching multiple values from a single URL Segment
        app.MapGet("{first}/{second}.{third}", async context =>
                {
                    await context.Response.WriteAsync("Request was routed\n");
                    foreach (var kvp in context.Request.RouteValues)
                    {
                        await context.Response.WriteAsync($"Key:{kvp.Key} - Value={kvp.Value} \n");
                    }
                }

            );

        //? ******üçüncü Route***************************************/

        //Catchall Segment Variable
        app.MapGet("{first}/{second}/{*catchall}", async context =>
        {
            await context.Response.WriteAsync("Request Was Routed\n");
            foreach (var kvp in context.Request.RouteValues)
            {
                await context.Response.WriteAsync($"{kvp.Key}: {kvp.Value}\n");
            }
        });

    }

);
#pragma warning restore ASP0014 // Suggest using top level route registrations

app.MapGet("/", () => "Hello World!");

app.Run();
