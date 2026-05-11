namespace MiProyectoAcademico.Domain.Entities;

public class Curso
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string Codigo { get; set; } = string.Empty;
    public int Creditos { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
}
