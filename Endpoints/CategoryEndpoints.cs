using CrudSqlite.Controllers;
using CrudSqlite.Data;
using CrudSqlite.Model;

namespace CrudSqlite.Endpoints;

public static class CategoryEndpoints
{
    private static readonly ApplicationDbContext _context = new();
    private static readonly PeopleControllers _peopleController = new(_context);
    public static void MapCategoryEndpoints(WebApplication app)
    {
        app.MapGet("/peoples", _peopleController.GetAll);
        app.MapGet("/peoples/{id}", (int id) => _peopleController.Find(id));
        app.MapPost("/peoples", (People people) =>  _peopleController.Create(people));
        app.MapPut("/peoples/{id}", (int id, People people) => _peopleController.Update(id, people));
        app.MapDelete("/peoples/{id}", (int id) => "Deletar pessoa!");
    }
}