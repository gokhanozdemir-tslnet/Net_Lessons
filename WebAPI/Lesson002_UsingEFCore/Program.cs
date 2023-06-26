using Lesson002_UsingEFCore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<WAPILesson002DbContext>(
    (optionbuilder)=> optionbuilder.UseSqlServer(
         builder.Configuration.GetConnectionString("DbConnectionString")
        )
    );

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
