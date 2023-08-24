using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

    public class Estado
    {
        [Key]
        public int? CodEstado { get; set; }
        public string? NombreEstado { get; set; }
        public string? CodPais { get; set; }
        public string? IdPais { get; set; }
        public Pais? Pais { get; set; }
        public ICollection<Region>? Regiones { get; set; }
        
    }
