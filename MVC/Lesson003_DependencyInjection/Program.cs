using Lesson003_DependencyInjection.Services;
using Lesson003_DependencyInjection.Utils;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IResponseFormatter, HtmlResponseFormatter>();


builder.Services.AddTransient<ITransientService, OperationService>();
builder.Services.AddScoped<IScopedService, OperationService>();
builder.Services.AddSingleton<ISingletonService, OperationService>();




var app = builder.Build();


app.UseStaticFiles();


app.MapDefaultControllerRoute();
//app.MapGet("/", () => "Hello World!");

app.Run();
