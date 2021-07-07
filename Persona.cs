namespace GestionFarmacia
{
    public class Persona: Direccion
    {
        string _Nombre;
        string _Apellido;
        string _Cedula;
        string _Telefono;
        public Persona(int id, string nombre, string apellido, string cedula, string telefono, string callePrincipal, string calleSecundaria):base( id, callePrincipal, calleSecundaria)
        {
            _Nombre = nombre;
            _Apellido = apellido;
            _Cedula = cedula;
            _Telefono = telefono;
        }
        public string Nombre{get=>_Nombre; set=>_Nombre = value;}
        public string Apellido{ get => _Apellido; set => _Apellido = value; }
        public string Cedula{ get => _Cedula; set => _Cedula = value; }
        public string Telefono{ get => _Telefono; set => _Telefono = value; }
    }
}