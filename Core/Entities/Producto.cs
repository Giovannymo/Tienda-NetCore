using System.ComponentModel.DataAnnotations;
namespace Core.Entities;

    public class Producto
    {
        public int? IdProducto { get; set; }
        public string? NombreProducto { get; set; }
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int? StockMinimo { get; set; }
        public int? StockMaximo { get; set; }
        public DateTime FechaCreacion { get; set; }

        
    }
