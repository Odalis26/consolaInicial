using System.Collections.Generic;
namespace GestionFarmacia
{
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string Nombre { get; set; }
        public string Ruc { get; set; }
        public string Telefono { get; set; }
        public FiltroPorCampos FiltroPorCampos { get; set; }
        public List<Proveedor> Proveedores { get; set; }
        public List<Farmacia> Farmacias { get; set; }
        public List<Empresa> Empresas { get; set; }
        public void FiltradorPorCampos(string campo, string valor, Empresa empresaRaiz)
        {
            FiltroPorCampos.FiltradorPorCampos(campo, valor, empresaRaiz);
        }
    }
}