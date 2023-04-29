using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Lesson003_Autofac.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//Configuration of Autofac

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()); //set di 
builder.Host.ConfigureContainer<ContainerBuilder>(   //configuration
    containerBuilder =>
    {
        containerBuilder.RegisterType<Transient>().As<ITransient>().InstancePerLifetimeScope();
        containerBuilder.RegisterType<Scope>().As<IScope>().InstancePerDependency();
        containerBuilder.RegisterType<Singleton>().As<ISingleton>().SingleInstance();

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
