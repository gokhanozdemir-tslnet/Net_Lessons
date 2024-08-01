using Microsoft.AspNetCore.Http;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var app = builder.Build();

List<Country> countries = new List<Country>
{
     new Country { Id = 1, Name = "United States" },
     new Country   { Id = 2,Name =  "Canada" },
     new Country   { Id = 3,Name =  "United Kingdom" },
     new Country   { Id = 4,Name =  "India" },
     new Country   { Id = 5,Name =  "Japan" }
};

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapGet("countries",
        async context =>
        {
            context.Response.StatusCode = 200;
            foreach (var country in countries)
            {
                await context.Response.WriteAsync($"{country.Id}, {country.Name} \n");
            }
        }
    );

  _ =  endpoints.MapGet("countries/{id:int:range(1,100)}",
        async context =>
        {
            if (context.Request.RouteValues.ContainsKey("id") == false)
            {
                context.Response.StatusCode = 400;
                await context.Response.WriteAsync("The id should be between 1 and 100");
            }

            int id = Convert.ToInt32(context.Request.RouteValues["id"]);

            if (countries.Any(x => x.Id == id))
            {
                string countryName = countries.Where(x => x.Id == id).First().Name;

                //write country name to response
                await context.Response.WriteAsync($"{countryName}");
            }
            else
            {
                context.Response.StatusCode = 404;
                await context.Response.WriteAsync($"[No country]");
            }
        }
    );

   _ = endpoints.MapGet("/countries/{countryID:min(101)}", async context =>
    {
        context.Response.StatusCode = 400;
        await context.Response.WriteAsync("The CountryID should be between 1 and 100 - min");
    });

});




app.Run(async context =>
{
    await context.Response.WriteAsync("No response");
});

app.Run();

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
}
