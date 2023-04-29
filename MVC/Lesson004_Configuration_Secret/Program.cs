var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

var app = builder.Build();


app.MapDefaultControllerRoute();


app.Run();


//User Secret
// # dotnet user-secrets init
// # dotnet user-secrets set "SecretKey" "SecretValue"
// # dotnet user-secrets list