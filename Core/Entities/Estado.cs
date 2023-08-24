using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

    public class Estado
    {
        [Key]
        public string? CodEstado { get; set; }
        public string? NombreEstado { get; set; }
        public string? CodPais { get; set; }
        public string? IdPais { get; set; }
        public Pais? Pais { get; set; }
    }
