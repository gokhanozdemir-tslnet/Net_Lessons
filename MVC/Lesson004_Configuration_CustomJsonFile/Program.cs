var builder = WebApplication.CreateBuilder(args);


builder.Host.ConfigureAppConfiguration(
    (hostingFile, config) =>
    {
        config.AddJsonFile("MyCustomConfFile.json", optional: true,
            reloadOnChange: true);
    }
    );


string con = builder.Configuration.GetConnectionString("DefaultConnection");
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
