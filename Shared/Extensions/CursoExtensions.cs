using LP3.BlazorServer.Domain.Entities;
using LP3.BlazorServer.Shared.DTOs;

namespace LP3.BlazorServer.Shared.Extensions;

public static class CursoExtensions
{
    public static CursoDto ToDto(this Curso curso)
    {
        return new CursoDto
        {
            Id = curso.Id,
            Nombre = curso.Nombre,
            Descripcion = curso.Descripcion,
            Codigo = curso.Codigo,
            Creditos = curso.Creditos,
            FechaInicio = curso.FechaInicio,
            FechaFin = curso.FechaFin
        };
    }

    public static Curso ToEntity(this CursoDto dto)
    {
        return new Curso
        {
            Id = dto.Id,
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion,
            Codigo = dto.Codigo,
            Creditos = dto.Creditos,
            FechaInicio = dto.FechaInicio,
            FechaFin = dto.FechaFin
        };
    }

    public static Curso ToEntity(this CursoFormDto dto)
    {
        return new Curso
        {
            Id = dto.Id ?? 0,
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion,
            Codigo = dto.Codigo,
            Creditos = dto.Creditos,
            FechaInicio = dto.FechaInicio,
            FechaFin = dto.FechaFin
        };
    }

    public static CursoDto ToDto(this CursoFormDto dto)
    {
        return new CursoDto
        {
            Id = dto.Id ?? 0,
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion,
            Codigo = dto.Codigo,
            Creditos = dto.Creditos,
            FechaInicio = dto.FechaInicio,
            FechaFin = dto.FechaFin
        };
    }
}
