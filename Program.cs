  using System;

namespace Ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int CantidadElementos = 6;
            var edificio = new int[CantidadElementos];
            edificio[0] = 556;
            edificio[1] = 136;
            edificio[2] = 23;
            edificio[3] = 347;
            edificio[4] = 125;
            edificio[5] = -57;

            Console.WriteLine(edificio[0]);

            var administrador = new Administrador();
            int [] edificiordenado = administrador.OrdenarConPivot(edificio);

            Console.WriteLine("Con For...");
            for (int i = 0; i < edificiordenado.Length; i++)
                Console.WriteLine(edificio[i]); 

            Console.WriteLine("Con Foreach");
            foreach (var actual in edificiordenado)
                Console.WriteLine(actual);


        }
    }
}