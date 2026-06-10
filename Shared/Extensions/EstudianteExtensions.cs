using LP3.BlazorServer.Domain.Entities;
using LP3.BlazorServer.Shared.DTOs;

namespace LP3.BlazorServer.Shared.Extensions;

public static class EstudianteExtensions
{
    public static EstudianteDto ToDto(this Estudiante estudiante)
    {
        return new EstudianteDto
        {
            Id = estudiante.Id,
            Nombre = estudiante.Nombre,
            Apellido = estudiante.Apellido,
            Matricula = estudiante.Matricula,
            Email = estudiante.Email,
            Telefono = estudiante.Telefono,
            FechaNacimiento = estudiante.FechaNacimiento,
            NumeroDocumento = estudiante.NumeroDocumento,
            Estado = estudiante.Estado,
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
            Matricula = dto.Matricula,
            Email = dto.Email,
            Telefono = dto.Telefono,
            FechaNacimiento = dto.FechaNacimiento,
            NumeroDocumento = dto.NumeroDocumento,
            Estado = dto.Estado,
            FechaRegistro = dto.FechaRegistro
        };
    }
}
