namespace InyeccionIndependencia
{
    public class CreadorArchivoTxt : Creador
    {
        public override string CreadorArchivo(Producto producto)
        {
            return $"Creando archivo de {producto.Nombre}. Tipo Txt";
        }
    }
}