// (c) 2026 Guillermo Roger Hernandez Chandia - ADS
using Microsoft.EntityFrameworkCore;
using GuardianSystem.Models;

namespace GuardianSystem.Data;

public class GuardianContext : DbContext
{
    public GuardianContext(DbContextOptions<GuardianContext> options) : base(options) { }

    public DbSet<GuardianLog> Logs { get; set; }
}
