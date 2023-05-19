using Lesson010_HttpClient.SericeContracts;
using Lesson010_HttpClient.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//add service
builder.Services.AddHttpClient();

//add Myservice 
//builder.Services.AddScoped<MyService>();
builder.Services.AddScoped<ITodoService, TodoSerice>();

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
