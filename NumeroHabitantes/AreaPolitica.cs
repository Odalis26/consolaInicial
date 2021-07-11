
using System.Collections.Generic;
using System.Linq;
namespace NumeroHabitantes
{
    internal class AreaPolitica
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public TipoArea TipoArea { get; set; }
        public int Habitantes { get; set; }
        public List<AreaPolitica> AreaPoliticas { get; set; } = new List<AreaPolitica>();
        public int ObtenerNumeroHabitantes()
        {
            if (!AreaPoliticas.Any())
                return Habitantes;
            else
            {
                int acumulador = 0;
                foreach (AreaPolitica actual in AreaPoliticas)
                    acumulador += actual.ObtenerNumeroHabitantes();

                return acumulador;
            }
        }
    }
}
