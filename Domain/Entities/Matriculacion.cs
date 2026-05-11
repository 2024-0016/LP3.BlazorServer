namespace MiProyectoAcademico.Domain.Entities;

public class Matriculacion
{
    public int Id { get; set; }
    public int EstudianteId { get; set; }
    public int CursoId { get; set; }
    public DateTime FechaMatricula { get; set; } = DateTime.Now;
    public decimal Calificacion { get; set; }
    public bool Aprobado { get; set; }
}
