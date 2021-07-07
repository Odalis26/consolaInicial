using System.Collections.Generic;
namespace GestionFarmacia
{
    public class Farmacia
    {
        public int FarmaciaId { get; set; }
        public string Nombre { get; set; }
        public string Ruc { get; set; }
        public string Ruta { get; set; } = "D:\\";
        public string Telefono { get; set; }
        public List<Vendedor> Vendedores { get; set; }
        public GeneradorDeArchivos GeneradorDeArchivo { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public string ToXml(Empresa empresaRaiz)
        {
            return GeneradorDeArchivo.ToXml(Ruta, empresaRaiz);
        }
    }
}