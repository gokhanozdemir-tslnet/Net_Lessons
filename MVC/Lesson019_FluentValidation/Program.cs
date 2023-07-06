using FluentValidation;
using FluentValidation.AspNetCore;
using Lesson019_FluentValidation.Entities;
using Lesson019_FluentValidation.Validations;
using Microsoft.CodeAnalysis.CSharp.Syntax;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddFluentValidation(
    
    x=>x.RegisterValidatorsFromAssemblyContaining<PersonValidator>()
    
    );


    //AddFluentValidation(
    //    option =>
    //    {
    //        option.ImplicitlyValidateChildProperties = true;
    //        option.ImplicitlyValidateRootCollectionElements = true;

    //        option.RegisterValidatorsFromAssembly(typeof(Person).Assembly);
           
    //    }
    //);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
