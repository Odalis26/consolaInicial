using System.IO;
using System.Text;
namespace GestionFarmacia
{
    public class GeneradorDeArchivos
    {
        public string ToXml(string ruta, Empresa empresaRaiz)
        {
            var empresas = "";
            var farmacias = "";
            var clientes = "";
            var vendedores = "";
            var productos = "";
            var datosEmpresaRaiz = $"<id>{empresaRaiz.EmpresaId}</id>" +
            $"<nombre>{empresaRaiz.Nombre} </nombre> " +
            $"<ruc>{empresaRaiz.Ruc}</ruc> " +
            $"<telefono>{empresaRaiz.Telefono}</telefono>";
            for (int i = 0; i < empresaRaiz.Empresas.Count; i++)
            {
                for (int z = 0; z < empresaRaiz.Empresas[i].Farmacias.Count; z++)
                {
                    if (empresaRaiz.Empresas[i].Farmacias[z].Clientes != null)
                    {
                        for (int a = 0; a < empresaRaiz.Empresas[i].Farmacias[z].Clientes.Count; a++)
                        {
                            clientes += $"<clientes{a}><nombre>{empresaRaiz.Empresas[i].Farmacias[z].Clientes[a].Nombre}</nombre>" +
                                $"<apellido>{empresaRaiz.Empresas[i].Farmacias[z].Clientes[a].Apellido}</apellido></clientes{a}>";
                        }
                    }
                    if (empresaRaiz.Empresas[i].Farmacias[z].Vendedores != null)
                    {
                        for (int b = 0; b < empresaRaiz.Empresas[i].Farmacias[z].Vendedores.Count; b++)
                        {
                            vendedores += $"<vendedor{b}><nombre>{empresaRaiz.Empresas[i].Farmacias[z].Vendedores[b].Nombre}</nombre>" +
                                $"<cargo>{empresaRaiz.Empresas[i].Farmacias[z].Vendedores[b].Cargo}</cargo></vendedor{b}>";
                        }
                    }
                    if (empresaRaiz.Empresas[i].Farmacias[z].Productos != null)
                    {
                        for (int c = 0; c < empresaRaiz.Empresas[i].Farmacias[z].Productos.Count; c++)
                        {
                            productos += $"<producto{c}><nombre>{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].NombreProducto}</nombre>" +
                                $"<precio>{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].Precio}</precio></producto{c}>";
                        }
                    }
                    farmacias += $"<farmacia{z}><nombre>{empresaRaiz.Empresas[i].Farmacias[z].Nombre}</nombre>" +
                        $"<telefono>{empresaRaiz.Empresas[i].Farmacias[z].Telefono}</telefono>" +
                        $"<clientes>{clientes}</clientes>" +
                        $"<vendedores>{vendedores}</vendedores>" +
                        $"<productos>{productos}</productos>" +
                        $"</farmacia{z}>";
                }
                empresas += $"<empresa{i}><id>{empresaRaiz.Empresas[i].EmpresaId}</id>" +
                   $"<nombre>{empresaRaiz.Empresas[i].Nombre} </nombre> " +
                   $"<ruc>{empresaRaiz.Empresas[i].Ruc}</ruc> " +
                   $"<telefono>{empresaRaiz.Empresas[i].Telefono}</telefono>" +
                   $"<farmacias>{farmacias}</farmacias></empresa{i}>";
            };

            var archivo = $"{ruta}\\{empresaRaiz.Nombre.Replace(" ", string.Empty)}.xml";
            FileStream fileStream = File.Create(archivo);
            var cabecera = $"<? xml version = \"1.0\" enconping = \"UTF-8\"?>";
            var contenido = $"{cabecera}<{empresaRaiz.Nombre}>" +
                $"{datosEmpresaRaiz}" +
                $"<empresas>{empresas}</empresas>" +
                $"</{empresaRaiz.Nombre}>";
            byte[] buffer = Encoding.UTF8.GetBytes(contenido);
            fileStream.Write(buffer);
            fileStream.Flush();
            fileStream.Close();
            return archivo;
        }
    }
}