// (c) 2026 Guillermo Roger Hernandez Chandia - ADS
using System.ComponentModel.DataAnnotations;

namespace GuardianSystem.Models;

public class GuardianLog
{
    public int Id { get; set; }
    public string Usuario { get; set; } = "Sistema_Anonimo";
    public string Acao { get; set; } = "Log_Vazio";
    public string Prioridade { get; set; } = "Baixa";
    public DateTime Timestamp { get; set; } = DateTime.Now;
}
