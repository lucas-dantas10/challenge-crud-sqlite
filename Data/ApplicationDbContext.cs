namespace CrudSqlite.Data;

using CrudSqlite.Model;
using Microsoft.EntityFrameworkCore;

class ApplicationDbContext : DbContext
{
    public  DbSet<People> Peoples { get; set; }
    public string DbPath { get; set; }

    public ApplicationDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "app.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=app.db");
}