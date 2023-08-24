using System.ComponentModel.DataAnnotations;
namespace Core.Entities;
    public class Region
    {
        [Key]
        public int? CodRegion { get; set; }
        public string? NombreRegion { get; set; }
        public int? IdEstado {get; set; }
        public Estado? Estado { get; set; }

        
    }
