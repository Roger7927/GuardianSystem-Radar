// (c) 2026 Guillermo Roger Hernandez Chandia - ADS
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GuardianSystem.Models;
using GuardianSystem.Data;

namespace GuardianSystem.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GuardianController : ControllerBase
{
    private readonly GuardianContext _context;

    public GuardianController(GuardianContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<GuardianLog>>> GetLogs([FromQuery] string? prioridade = null)
    {
        var consulta = _context.Logs.AsQueryable();
        if (!string.IsNullOrEmpty(prioridade))
            consulta = consulta.Where(l => l.Prioridade == prioridade);

        return await consulta.OrderByDescending(l => l.Timestamp).ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<GuardianLog>> PostLog(GuardianLog log)
    {
        _context.Logs.Add(log);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetLogs), new { id = log.Id }, log);
    }
}
