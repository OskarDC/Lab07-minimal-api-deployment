var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from Azure!");
app.MapGet("/oskar", () => "Hello from Oskar!");

app.Run();
