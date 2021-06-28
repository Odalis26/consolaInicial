using System.Linq;
using System.Collections.Generic;
namespace Tarea2Arboles
{
    internal class ManipuladorArbol
    {   
        internal int ContarNiveles(Nodo nodo)
        {
            int incrementador = 0;
            foreach (Nodo temporal in nodo.Hijos)
            {
                incrementador += temporal.Valor.Count();
            }
            return incrementador;
        }

        internal int ContadorNodos(Nodo nodo)
        {
            int incrementador = 0;
            incrementador+=nodo.nodoRaiz+nodo.Hijos.Count();
            foreach (Nodo temporal in nodo.Hijos)
            {
                incrementador+=temporal.Hijos.Count();
            }
            return incrementador;
        }


       

        internal int ContadorHojas(Nodo nodo)
        {
            int incrementador = 0;
            
            foreach (Nodo temporal in nodo.Hijos)
            {
                incrementador+=temporal.Hijos.Count();
            }
            return incrementador;
        }
        
       
    }
}