namespace CrudSqlite.Endpoints;

public static class CategoryEndpoints
{
    public static void MapCategoryEndpoints(WebApplication app)
    {
        app.MapGet("/peoples", () => "Todas as pessoas!");
        app.MapGet("/peoples/{id}", (string id) => "Uma pessoa!");
        app.MapPost("/peoples", () => "Cadastrar pessoa!");
        app.MapPut("/peoples/{id}", (string id) => "Atualizar pessoa!");
        app.MapDelete("/peoples/{id}", (string id) => "Deletar pessoa!");
    }
}