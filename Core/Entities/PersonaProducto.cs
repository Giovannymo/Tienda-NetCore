using System.ComponentModel.DataAnnotations;
namespace Core.Entities;
public class PersonaProducto
{
    [Key]
    public int? IdPersonaFk { get; set; }
    public Persona? Persona { get; set; }
    public int? IdProductoFk { get; set; }
    public Producto? Producto { get; set; }

}
