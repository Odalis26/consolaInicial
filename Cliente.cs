namespace GestionFarmacia
{
    public class Cliente : Persona
    {
        public Cliente(int id, string nombre, string apellido, string cedula, string telefono, string callePrincipal, string calleSecundaria) : base(id, nombre, apellido, cedula, telefono, callePrincipal, calleSecundaria)
        {
        }
        public string Direccion { get; set; }
    }
}