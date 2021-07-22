using System.IO;
using System.Text;

namespace InyeccionIndependencia
{
     public class CreadorDeArchivoXml : Creador
    {
        public override string CreadorArchivo(Producto producto, string ruta)
        {
           
            var file = $"{ruta}\\producto.xml";
            FileStream fileStream = File.Create(file);
            var header = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>";
            var content = $"<content><nombre>{producto.Nombre}</nombre><precio>{producto.Precio}</precio></content>";
            byte[] buffer = Encoding.UTF8.GetBytes(header + content);
            fileStream.Write(buffer);
            fileStream.Flush();
            fileStream.Close();

            return file;
        }
    }
}