using System.ComponentModel.DataAnnotations;
namespace Core.Entities;
public class PersonaProducto
{
    [Key]
    public string? IdPersona { get; set; }
    public Persona? Persona { get; set; }
    public int? IdProducto { get; set; }
    public Producto? Producto { get; set; }

}
