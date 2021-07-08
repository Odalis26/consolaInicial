using Ninject;

namespace InyeccionIndependencia
{
    public class GestorArchivo
    {
        public GestorArchivo()
        {
        }
        [Inject]
        public GestorArchivo(Creador creadorArchivo)
        {
            CreadorArchivo = creadorArchivo;
        }
        public Creador CreadorArchivo { get; set; }
        public string CrearArchivo(Producto producto)
        {
            return CreadorArchivo.CreadorArchivo(producto);
        }
    }
}