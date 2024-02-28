var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/peoples", () => "Pessoas!");
app.MapGet("/people/id", () => "Uma pessoa!");
app.MapPost("/people", () => "Cadastrar");
app.MapPut("/people/id", () => "Atualizar");
app.MapDelete("/people/id", () => "Deletar");

app.Run();
