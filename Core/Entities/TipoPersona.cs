using System.ComponentModel.DataAnnotations;
namespace Core.Entities;

public class TipoPersona
{
    [Key]
    public int? IdTipoPersona { get; set; }
    public string? Descripcion { get; set; }
    public ICollection<Persona>? Personas { get; set; }
    
}
