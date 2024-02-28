using CrudSqlite.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

CategoryEndpoints.MapCategoryEndpoints(app);

app.Run();
