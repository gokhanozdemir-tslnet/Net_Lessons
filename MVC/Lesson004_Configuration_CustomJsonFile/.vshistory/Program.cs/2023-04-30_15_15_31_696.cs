var builder = WebApplication.CreateBuilder(args);


builder.Host.ConfigureAppConfiguration(
    (hostingFile, config) =>
    {
        config.AddJsonFile("MyCustomConfFile.json", optional: true,
            reloadOnChange: true);
    }
    );

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
