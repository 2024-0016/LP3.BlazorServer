using LP3.BlazorServer.Domain.Enums;

namespace LP3.BlazorServer.Domain.Entities;

public class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Matricula { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public DateTime FechaNacimiento { get; set; }
    public string NumeroDocumento { get; set; } = string.Empty;
    public EstadoEstudiante Estado { get; set; } = EstadoEstudiante.Activo;
    public DateTime FechaRegistro { get; set; } = DateTime.Now;
}
