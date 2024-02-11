using Lesson021_LocalizationAndResource.Resources;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;
using System.Resources;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
        new CultureInfo("tr-TR"),
        new CultureInfo("en-US"),
        new CultureInfo("fr-FR")

    };

    options.DefaultRequestCulture = new RequestCulture(culture: "tr-TR", uiCulture: "tr-TR");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
    options.RequestCultureProviders = new List<IRequestCultureProvider>
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider()
                };

    //options.AddInitialRequestCultureProvider(new CustomRequestCultureProvider(async context =>
    //{
    //    // My custom request culture logic
    //    return await Task.FromResult(new ProviderCultureResult("tr"));
    //}));
});

builder.Services.AddLocalization
    (options => options.ResourcesPath = "Resources");

// Add services to the container.
builder.Services.AddControllersWithViews()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix);

builder.Services.AddSingleton<GlobalResource>();

//builder.Services.Configure<RequestLocalizationOptions>(options =>
//{
//    var supportedCultures = new[] { "en", "tr" };
//    options.SetDefaultCulture(supportedCultures[0])
//        .AddSupportedCultures(supportedCultures)
//        .AddSupportedUICultures(supportedCultures);
//});







var app = builder.Build();

//var supportedCultures = new[] { "tr", "en" };
//var localizationOption = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0])
//    .AddSupportedCultures(supportedCultures)
//    .AddSupportedUICultures(supportedCultures);

//app.UseRequestLocalization(localizationOption);

//app.UseRequestLocalization(new RequestLocalizationOptions
//{
//    ApplyCurrentCultureToResponseHeaders = true
//});

//app.UseRequestLocalization(options =>
//{
//    var questStringCultureProvider = options.RequestCultureProviders[0];
//    options.RequestCultureProviders.RemoveAt(0);
//    options.RequestCultureProviders.Insert(1, questStringCultureProvider);
//    options.CultureInfoUseUserOverride = true;
//    //options.ApplyCurrentCultureToResponseHeaders = true;
//});

app.UseRequestLocalization ();



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
