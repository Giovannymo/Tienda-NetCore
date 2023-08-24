using System.ComponentModel.DataAnnotations;
namespace Core.Entities;
public class PersonaProducto
{
    [Key]
    public int? IdPersona { get; set; }
    public Persona? Personas { get; set; }
    public int? IdProducto { get; set; }
    public Producto? Productos { get; set; }

}
