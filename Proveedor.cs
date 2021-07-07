namespace GestionFarmacia
{
    public class Proveedor : Persona
    {
        public Proveedor(int id, string nombre, string apellido, string cedula, string telefono, string callePrincipal, string calleSecundaria) : base(id, nombre, apellido, cedula, telefono, callePrincipal, calleSecundaria)
        {
        }
        public string Provincia { get; set; }
        public string NombreEmpresa { get; set; }
    }
}