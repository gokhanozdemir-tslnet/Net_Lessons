var builder = WebApplication.CreateBuilder(args);


//read simple configuration
string myKeyValue1 = builder.Configuration.GetSection("MyKey").Value ?? "";
string myKeyValue2 = builder.Configuration["MyKey"] ?? "";
string myKeyValue3 = builder.Configuration.GetValue<string>("MyKey") ?? "";
string myKeyValue4 = builder.Configuration.GetValue<string>("MyKey", "");


string masterKey1 = builder.Configuration.GetSection("MasterKey")["Key1"] ? "";
string masterKey2 = builder.Configuration.GetSection("MasterKey")["Key2"] ? "";
string masterKey3 = builder.Configuration.GetSection("MasterKey")["Key3"] ? "";

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.Logger.LogInformation($"myKey = {myKeyValue1}");
app.Logger.LogInformation($"myKey2 = {myKeyValue2}");
app.Logger.LogInformation($"myKey3 = {myKeyValue3}");
app.Logger.LogInformation($"myKey4 = {myKeyValue4}");

app.Logger.LogInformation($"masterKey1 = {masterKey1}");
app.Logger.LogInformation($"masterKey2 = {masterKey2}");
app.Logger.LogInformation($"masterKey3 = {masterKey3}");

app.MapDefaultControllerRoute();

app.Run();
