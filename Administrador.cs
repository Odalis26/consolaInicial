using System;

namespace Ordenamiento
{
    class Administrador 
    {
        internal int[] OrdenarConPivot(int[] desordenado)
        {
            for (int i = 0; i < desordenado.Length - 1; i++)
            {
                int posicionMenor = ObtenerPosicionDelMenor(desordenado, i);
                var intercambio = desordenado[i];       
                desordenado[i] = desordenado[posicionMenor];
                desordenado[posicionMenor] = intercambio;
            }
            return desordenado;
        }
        private int ObtenerPosicionDelMenor(int[] desordenado, int inicio)
        {
            int posicionMenor = inicio;
            for (int posicionActual = inicio; posicionActual < desordenado.Length; posicionActual++)
                if (desordenado[posicionActual] < desordenado[posicionMenor])
                    posicionMenor = posicionActual;
            return posicionMenor;
        }
    }
}