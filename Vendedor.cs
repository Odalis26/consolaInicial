namespace GestionFarmacia
{
    public class Vendedor : Persona
    {
        public Vendedor(int id, string nombre, string apellido, string cedula, string telefono, string callePrincipal, string calleSecundaria) : base(id, nombre, apellido, cedula, telefono, callePrincipal, calleSecundaria)
        {
        }
        public string Cargo { get; set; }
        public string NombreEmpresa { get; set; }
    }
}