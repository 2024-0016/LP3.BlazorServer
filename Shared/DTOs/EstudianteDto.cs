namespace MiProyectoAcademico.Shared.DTOs;

public class EstudianteDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Telefono { get; set; } = string.Empty;
    public DateTime FechaNacimiento { get; set; }
    public string NumeroDocumento { get; set; } = string.Empty;
    public DateTime FechaRegistro { get; set; }
}
