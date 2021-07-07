using System;
namespace GestionFarmacia
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int Stock { get; set; }
        public float Precio { get; set; }
    }
}