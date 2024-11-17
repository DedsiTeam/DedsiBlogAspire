using DBA.AspNetCore;
using DBA.Identity.Infrastructure.EntityFrameworkCore;
using DBA.Identity.Infrastructure.Repositories.Users;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

builder.Services.AddControllers();
builder.Services.AddOpenApi();

// EF Core: Sql Server DB
builder.AddAspireSqlServerDbContext<IdentityDbContext>("IdentityDB");

builder.Services.AddTransient<IUserRepository, UserRepository>();

var app = builder.Build();

app.MapDefaultEndpoints();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseScalarUi();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
