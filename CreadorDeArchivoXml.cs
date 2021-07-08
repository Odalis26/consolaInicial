namespace InyeccionIndependencia
{
     public class CreadorDeArchivoXml : Creador
    {
        public override string CreadorArchivo(Producto producto)
        {
            return $"Generando archivo de {producto.Nombre}. Tipo Xml";
        }
    }
}