using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AJGR20250324S2.AppWebMVC.Models;

public partial class Estudiante
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Los nombres son obligatorios")]
    [Display(Name = "Nombres")]
    public string Nombre { get; set; } = null!;

    [Required(ErrorMessage = "Los apellidos son obligatorios")]
    [Display(Name = "Apellidos")]
    public string Apellido { get; set; } = null!;

    [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
    [Display(Name = "Fecha de Nacimiento")]
    public DateOnly FechaNacimiento { get; set; }

    [Display(Name = "Correo Electrónico")]
    public string? CorreoElectronico { get; set; }

    [Display(Name = "Teléfono")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "El grado es obligatorio")]
    public int Grado { get; set; }

    public decimal? Promedio { get; set; }

    [Required(ErrorMessage = "La fecha de inscripción es obligatoria")]
    [Display(Name = "Fecha de Inscripción")]
    public DateTime? FechaInscripcion { get; set; }
}
