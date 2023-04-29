var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();





//!? UseWhen branch 
app.UseWhen(
    context => context.Request.Query.ContainsKey("username"),
    app => app.Use(
        async (context, next) =>
        {
            await context.Response.WriteAsync("Hello usewhen");
            await next(context);
        }
        )
    );



//MapGet :IEndpointRouteBuilder interfacsinden bir extension methoddur.
app.Map("/alltype", () => "All type");  // tüm request tiplerine cevap döner.
app.MapGet("/", () => "Get Type!"); //sadece Get tipinde isteklere cevap verir
app.MapPost("/mypost", () => "Post Type"); //sadece Post tipinde isteklere cevap verir


app.Run();



//! Important - formatted as bold.
//? Question - colored red.
//x Removed - formatted as strikethrough.
//TODO: Task - colored light green.
//!? WT*‽ - colored Purple.