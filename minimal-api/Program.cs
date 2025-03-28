var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from Azure!");
app.MapGet("/oskar", () => "Hello from Oskar!");
app.MapGet("/roennie", () => new 
{
    name = "Roennie",
    address = "Mouterijstraat 26",
    car = "Ford Fiesta",
    maite = "Yes"
});

app.Run();
