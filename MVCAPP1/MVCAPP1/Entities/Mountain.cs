using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP1.Entities
{
    public class Mountain
    {
        
        public int MountainId { get; set; }
        [DisplayName("Nombre de la montaña")]
        public string Nombre { get; set; }
        [DisplayName("Altitud en metros")]
        public int Altitud { get; set; }
    }
}
