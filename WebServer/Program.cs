var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Привет от ИСП-232! Автор: Спиридонова Александра");

app.Run();
