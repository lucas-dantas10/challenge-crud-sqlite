using CrudSqlite.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudSqlite.Database;

class PeopleContext : DbContext
{
    public PeopleContext(DbContextOptions<PeopleContext> options) : base(options) {}

    public DbSet<People> Peoples => Set<People>();
}