using CrudSqlite.Data;
using CrudSqlite.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace CrudSqlite.Controllers;

class PeopleControllers(ApplicationDbContext dbContext)
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<List<People>> GetAll()
    {
        return await _dbContext.Peoples.ToListAsync();
    }

    public async Task<People?> Find(int id)
    {
        return await _dbContext.Peoples.FirstOrDefaultAsync(people => people.Id == id);
    }

    public async Task<string> Create(People people)
    {
        await _dbContext.Peoples.AddAsync(people);
        await _dbContext.SaveChangesAsync();

        return "Pessoa cadastrada!";
    }

    public async Task<string> Update(int id, People people)
    {
        var peopleFind = await _dbContext.Peoples.FirstOrDefaultAsync(people => people.Id == id);

        if (peopleFind == null)
        {
            return "Pessoa não encontrada!";
        }
        
        if (!string.IsNullOrWhiteSpace(people.Name))
        {
            peopleFind.Name = people.Name;
        }

        if (people.Age != 0)
        {
            peopleFind.Age = people.Age;
        }

        _dbContext.Peoples.Update(peopleFind);

        return "Pessoa atualizada!";
    }
}