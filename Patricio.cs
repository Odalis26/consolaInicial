using System;

namespace BobEsponja

{

    class PatricioEstrtella
    {

        public void AmigoPatricio()
        {
            Console.WriteLine("¿Quién es Patricio Estrella en la serie de Bob Esponja? ");
            var caracteristicasPatricio = Console.ReadLine();

            Console.WriteLine("¿Qué se pone Patricio Estrella para dormir? ");
            var ropaPatricio = Console.ReadLine();

            Console.WriteLine("¿En dónde vive Patricio Estrella? ");
            var lugarPatricio = Console.ReadLine();

            Console.WriteLine("¿Quién creó la voz de Patricio? ");
            var nombreCreadorVoz = Console.ReadLine();

            Console.WriteLine("¿Cuál es el sexo de Patricio Estrella? ");
            var sexoPatricio = Console.ReadLine();

            Console.WriteLine("¿De qué color son los ojos de Patricio Estrella? ");
            var ojosPatricio = Console.ReadLine();

            Console.WriteLine("¿Cuáles son los enemigos de Patricio Estrella? ");
            var enemigosPatricio= Console.ReadLine();

            Console.WriteLine("¿Cuánto pesa Patricio Estrella? ");
            float pesoPatricio1;
            while (true)
            {
                string pesoPatricio = Console.ReadLine();
                if (!float.TryParse(pesoPatricio, out pesoPatricio1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };
            Console.WriteLine("¿Cuánto mide Patricio Estrella?  ");
            float estaturaPatricio1;
            while (true)
            {
                string estaturaPatricio = Console.ReadLine();
                if (!float.TryParse(estaturaPatricio, out estaturaPatricio1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };
            
            Console.WriteLine("¿Quién es el primo lejano de Patricio Estrella?  ");
            var primoPatricio = Console.ReadLine();
            
        }
       
    }
    
}
