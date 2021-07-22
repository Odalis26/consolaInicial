using System.IO;
using System.Text;

namespace InyeccionIndependencia
{
    public class CreadorArchivoTxt : Creador
    {
        public override string CreadorArchivo(Producto producto, string ruta)
        {
            string archivo = $"{ruta}productos.txt";
            FileStream fileStream = File.Create(archivo);
            var content = $"Nombre: {producto.Nombre} precio: {producto.Precio}";
            byte[] buffer = Encoding.UTF8.GetBytes(content);
            fileStream.Write(buffer);
            fileStream.Flush();
            fileStream.Close();

            return archivo;
        }


    }
}