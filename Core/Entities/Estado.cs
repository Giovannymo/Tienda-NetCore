using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

    public class Estado
    {
        [Key]
        public int? IdEstado { get; set; }
        public string? NombreEstado { get; set; }
        public int? IdPaisFk { get; set; }
        public Pais? Pais { get; set; }
        public ICollection<Region>? Regiones { get; set; }
        
    }
