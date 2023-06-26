using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    options => options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory,"api.xml") )
    );

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
