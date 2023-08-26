using System.ComponentModel.DataAnnotations;
namespace Core.Entities;
    public class Region
    {
        [Key]
        public int? IdRegion { get; set; }
        public string? NombreRegion { get; set; }
        public int? IdEstadoFk {get; set; }
        public Estado? Estado { get; set; }
        public ICollection<Persona>? Personas { get; set; }



        
    }
