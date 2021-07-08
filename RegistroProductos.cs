using System.Collections.Generic;

namespace InyeccionIndependencia
{
    class RegistroProducto
    {
        public string UrlSitioWeb { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public Creador GeneradorArchivo { get; set; }
    }
}