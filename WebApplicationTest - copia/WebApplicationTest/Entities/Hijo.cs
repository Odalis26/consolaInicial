using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTest.Entities
{
    public class Hijo
    {
        public int HijoId { get; set; }
        public string Nombre { get; set; }
        public string Apillido { get; set; }
       // [ForeignKey](Empleado)
        //public string EmpleadoId { get; set; }

        public Empleado Empleado { get; set; }
    }
}