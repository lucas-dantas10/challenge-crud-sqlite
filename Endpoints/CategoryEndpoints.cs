using CrudSqlite.Controllers;
using CrudSqlite.Data;

namespace CrudSqlite.Endpoints;

public static class CategoryEndpoints
{
    private static readonly ApplicationDbContext _context = new();
    private static readonly PeopleControllers _peopleController = new(_context);
    public static void MapCategoryEndpoints(WebApplication app)
    {
        app.MapGet("/peoples", _peopleController.GetAllPeoples);
        app.MapGet("/peoples/{id}", (string id) => "Uma pessoa!");
        app.MapPost("/peoples", () => "Cadastrar pessoa!");
        app.MapPut("/peoples/{id}", (string id) => "Atualizar pessoa!");
        app.MapDelete("/peoples/{id}", (string id) => "Deletar pessoa!");
    }
}