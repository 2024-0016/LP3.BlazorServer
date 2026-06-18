namespace LP3.BlazorServer.Shared.DTOs;

public class CursoFormDto
{
    public int? Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string Codigo { get; set; } = string.Empty;
    public int Creditos { get; set; }
    public DateTime FechaInicio { get; set; } = DateTime.Today;
    public DateTime FechaFin { get; set; } = DateTime.Today.AddMonths(3);
}
