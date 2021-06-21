using System;

namespace BobEsponja

{
    class Informacion
    {
        public void Datos()
        {
            Console.WriteLine("¿Cuál es el personaje principal de la serie animada Bob Esponja?");
            var nombrePersonaje = Console.ReadLine();

            Console.WriteLine("¿Quién creó Bob Esponja?");
            var nombreCreador = Console.ReadLine();

            Console.WriteLine("¿Quién interpretó la voz de Bob Esponja?");
            var nombreInterpretador = Console.ReadLine();
            
            Console.WriteLine("¿En que año se emitió la serie animada Bob Esponja?");
            int anioEmicion1;
            while (true)
            {
                string anioEmicion = Console.ReadLine();
                if (!int.TryParse(anioEmicion, out anioEmicion1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };
            
            Console.WriteLine("¿Quién diseño el personaje Bob Esponja?");
            var nombreDiseñador = Console.ReadLine();
            
            Console.WriteLine("¿En qué vive Bob Esponja?");
            var Casa = Console.ReadLine();

            Console.WriteLine("En qué ciudad vive Bob Esponja?");
            var ciudad = Console.ReadLine();

            Console.WriteLine("¿En dondé trabaja Bob Esponja?");
            var sitio = Console.ReadLine();
            
            Console.WriteLine("¿Cuál es el nombre de la mascota de Bob Esponja?");
            var nombreMascota = Console.ReadLine();

            Console.WriteLine("¿Cuál es el mejor amigo de Bob Esponja?");
            var mejorAmigo = Console.ReadLine();
            
        }
    }  
}