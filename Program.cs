// (c) 2026 Guillermo Roger Hernandez Chandia - ADS
using Microsoft.EntityFrameworkCore;
using GuardianSystem.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuração da Injeção de Dependência (Dependency Injection) para o Banco
builder.Services.AddDbContext<GuardianContext>(options =>
    options.UseSqlite("Data Source=guardian.db"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Lógica de Inicialização: Garante que o banco exista na primeira execução
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<GuardianContext>();
    db.Database.EnsureCreated();
}

// --- AJUSTE DE PRODUÇÃO (Render) ---
// Removemos a trava do 'IsDevelopment' para o Swagger aparecer na nuvem
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sentinel Radar V1");
    c.RoutePrefix = string.Empty; // Isso faz o Swagger ser a página inicial da URL
});
// -----------------------------------

app.UseAuthorization();
app.MapControllers();
app.Run();
