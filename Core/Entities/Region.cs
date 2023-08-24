using System.ComponentModel.DataAnnotations;
namespace Core.Entities;
    public class Region
    {
        [Key]
        public string? CodRegion { get; set; }
        public string? NombreRegion { get; set; }
        public string? IdEstado {get; set; }
        public Estado? Estado { get; set; }
        
    }
