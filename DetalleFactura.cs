using System.Collections.Generic;
namespace GestionFarmacia
{
    public class DetalleFactura
    {
        public int DetalleFacturaId { get; set; }
        public string CodigoFactura { get; set; }
        public string CodigoProducto { get; set; }
        public string CantidadProducto { get; set; }
        public string TipoMoneda { get; set; }
        public List<Producto> Productos { get; set; }
    }
}