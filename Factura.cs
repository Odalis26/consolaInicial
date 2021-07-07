using System;
using System.Collections.Generic;
namespace GestionFarmacia
{
    public class Factura
    {
        public int FacturaId { get; set; }
        public string CodigoCliente { get; set; }
        public string CodigoProducto { get; set; }
        public string CodigoEmpresa { get; set; }
        public string CantidadProducto { get; set; }
        public string TipoMoneda { get; set; }
        public DateTime FechaActual { get; set; }
        public List<TipoMoneda> Monedas { get; set; }
        public float TotalFactura { get; set; }
        public List<Producto> Productos { get; set; }
    }
}