using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Configuration of Autofac

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()); //set di 
builder.Host.ConfigureContainer<ContainerBuilder>(   //configuration
    containerBuilder =>
    {

    });

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
