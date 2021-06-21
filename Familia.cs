using System;

namespace BobEsponja

{
    class Familia
    {
        public void Familiares()
        {
            Console.WriteLine("¿Cuál es el nombre del tío de Bob Esponja?");
            var nombreTio = Console.ReadLine();
            Console.WriteLine("¿Cómo se llama el abuelo de Bob Esponja?");
            var nombreAbuelo = Console.ReadLine();
            Console.WriteLine("¿Cuántos años tiene el abuelo de Bob Esponja?");
            int edad2;
            while (true)
            {
                string edadAbuelo = Console.ReadLine();
                if (!int.TryParse(edadAbuelo, out edad2))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };
            Console.WriteLine("¿Cómo se llama el primo  de Bob Esponja?");
            var nombrePrimo = Console.ReadLine();
            Console.WriteLine("¿Cuántos años tiene el primo Cachiporras de Bob Esponja?");
            int edad3;
            while (true)
            {
                string edadPrimo = Console.ReadLine();
                if (!int.TryParse(edadPrimo, out edad3))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };
            Console.WriteLine("¿Cuál es el nombre de la abuela de Bob Esponja?");
            var nombreAbuela = Console.ReadLine();
            Console.WriteLine("¿Cuál es el nombre del ancestro prehistórico temprano de Bob Esponja?");
            var nombreAncestro1 = Console.ReadLine();
            Console.WriteLine("¿Cuál es el nombre del Ancestro prehistórico tardío de Bob Esponja?");
            var nombreAncestro2 = Console.ReadLine();
            Console.WriteLine("¿Cuál es el nombre del Tatarabuelo del Oeste de Bob Esponja?");
            var nombreTatarabuelo = Console.ReadLine();
            Console.WriteLine("¿Cuál es el nombre del descendiente del futuro de Bob Esponja?");
            var nombreDescendienteFuturo = Console.ReadLine();
            
            
            
        }
    }  
}
