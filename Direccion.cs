namespace GestionFarmacia
{
    public  class Direccion 
    {
        int _Id;
        string _CallePrincipal;
        string _CalleSecundaria;
        public Direccion(int id, string callePrincipal, string calleSecundaria)
        {
            _Id = id;
            _CallePrincipal = callePrincipal;
            _CalleSecundaria = calleSecundaria;
        }
        public int Id { get=>_Id; set=>_Id = value ; }
        public string CallePrincipal { get=>_CallePrincipal; set=>_CallePrincipal = value ; }
        public string CalleSecundaria { get=>_CalleSecundaria; set=>_CalleSecundaria = value ; }
    }
}