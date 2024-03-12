using CrudSqlite.Data;
using CrudSqlite.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>();
var app = builder.Build();

CategoryEndpoints.MapCategoryEndpoints(app);

app.Run();
