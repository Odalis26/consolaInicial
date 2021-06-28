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
        
        public string ImprimirArbolInfijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $"( {ImprimirArbolInfijo(nodo.Hijos[1])} {nodo.Valor} {ImprimirArbolInfijo(nodo.Hijos[0])})";
        }
        public string ImprimirArbolInfijo2(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $"( {ImprimirArbolInfijo2(nodo.Hijos[0])} {nodo.Valor} {ImprimirArbolInfijo2(nodo.Hijos[1])})";
        }
        

        public string ImprimirArbolPrefijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $"{nodo.Valor} ( {ImprimirArbolPrefijo(nodo.Hijos[1])} {ImprimirArbolPrefijo(nodo.Hijos[0])})";
        }
        public string ImprimirArbolSegundoPrefijo(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $" ( {ImprimirArbolSegundoPrefijo(nodo.Hijos[1])}  {ImprimirArbolSegundoPrefijo(nodo.Hijos[0])}) {nodo.Valor}";   
        }
        public string ImprimirArbolPrefijo3(Nodo nodo)
        {
            if (!nodo.Hijos.Any())
                return nodo.Valor;

            return $"{nodo.Valor} ( {ImprimirArbolPrefijo3(nodo.Hijos[0])} {ImprimirArbolPrefijo3(nodo.Hijos[1])})";
        }
    }
}