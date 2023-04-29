using Lesson003_DependencyInjection.Utils;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddSingleton<IResponseFormatter, HtmlResponseFormatter>();


builder.Services.AddTransient<ITransientService, OperationService>();
builder.Services.AddScoped<IScopedService, OperationService>();
builder.Services.AddSingleton<ISingletonService, OperationService>();



app.MapGet("/", () => "Hello World!");

app.Run();
