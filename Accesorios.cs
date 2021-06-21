using System;

namespace BobEsponja

{
    class Accesorios
    {
        public void Familiares()
        {
            Console.WriteLine("¿Cuál es el de camisa que usa Bob Esponja?");
            var camisa = Console.ReadLine();
            
            Console.WriteLine("¿Qué color de corbata utiliza Bob Esponja?");
            var colorCorbata = Console.ReadLine();
            
            Console.WriteLine("¿De qué color son los pantalones de Bob Esponja?");
            var colorPantalones = Console.ReadLine();
            
            Console.WriteLine("¿De qué color es el cinturón de Bob Esponja?");
            var colorCinturon = Console.ReadLine();
            
            Console.WriteLine("¿Cuántas prendas utiliza Bob Esponja?");
            int prendas1;
            while (true)
            {
                string prendas = Console.ReadLine();
                if (!int.TryParse(prendas, out prendas1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };
            
            Console.WriteLine("¿Comó son las mangas de la camisa de Bob Esponja?");
            var mangasCamisa = Console.ReadLine();
            
            Console.WriteLine("¿De qué color son los calcetines de Bob Esponja?");
            var colorCalcetines = Console.ReadLine();
            
            Console.WriteLine("¿Cuál es el tamaño de los calcetines de Bob Esponja?");
            int tamaño1;
            while (true)
            {
                string tamaño = Console.ReadLine();
                if (!int.TryParse(tamaño, out tamaño1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };
            
            Console.WriteLine("¿De qué color son los zapatos de Bob Esponja?");
            var colorZapatos = Console.ReadLine();
            
            Console.WriteLine("¿De qué forma tiene los zapatos de Bob Esponja?");
            var formaZapatos= Console.ReadLine(); 
        }
    }  
}
