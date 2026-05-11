using MiProyectoAcademico.Domain.Entities;
using MiProyectoAcademico.Shared.DTOs;

namespace MiProyectoAcademico.Shared.Extensions;

public static class EstudianteExtensions
{
    public static EstudianteDto ToDto(this Estudiante estudiante)
    {
        return new EstudianteDto
        {
            Id = estudiante.Id,
            Nombre = estudiante.Nombre,
            Apellido = estudiante.Apellido,
            Email = estudiante.Email,
            Telefono = estudiante.Telefono,
            FechaNacimiento = estudiante.FechaNacimiento,
            NumeroDocumento = estudiante.NumeroDocumento,
            FechaRegistro = estudiante.FechaRegistro
        };
    }

    public static Estudiante ToEntity(this EstudianteDto dto)
    {
        return new Estudiante
        {
            Id = dto.Id,
            Nombre = dto.Nombre,
            Apellido = dto.Apellido,
            Email = dto.Email,
            Telefono = dto.Telefono,
            FechaNacimiento = dto.FechaNacimiento,
            NumeroDocumento = dto.NumeroDocumento,
            FechaRegistro = dto.FechaRegistro
        };
    }
}
