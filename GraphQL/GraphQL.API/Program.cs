using GraphiQl;
using GraphQL.Data;
using GraphQL.Data.Repository;
using GraphQL.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Courses.GraphQL.API", Version = "v1" });
});

var connectionString = builder.Configuration.GetConnectionString("DatabaseConnectionString");
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));
builder.Services.AddScoped<CoursesRepository>();

// GraphQL
builder.Services.AddGraphQL().AddSystemTextJson();

var app = builder.Build();

// Migration
await using var scope = app.Services.CreateAsyncScope();
await using (var db = scope.ServiceProvider.GetService<AppDbContext>()!)
{
    await db.Database.MigrateAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Courses.GraphQL.API v1"));
}

app.UseHttpsRedirection();

// GraphQL
//app.UseGraphQL<schemaCLass>();
app.UseGraphQLGraphiQL("/ui/graphql");

app.UseAuthorization();
app.MapControllers();

await app.RunAsync();
