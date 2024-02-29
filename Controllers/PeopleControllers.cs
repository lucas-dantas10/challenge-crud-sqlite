using CrudSqlite.Data;
using CrudSqlite.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudSqlite.Controllers;

class PeopleControllers(ApplicationDbContext dbContext)
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<List<People>> GetAllPeoples()
    {
        return await _dbContext.Peoples.ToListAsync();
    }
}