// (c) 2026 Guillermo Roger Hernandez Chandia - ADS
using Microsoft.EntityFrameworkCore;
using GuardianSystem.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<GuardianContext>(options =>
    options.UseSqlite("Data Source=guardian.db"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<GuardianContext>();
    db.Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
