using System;

namespace BobEsponja

{

    class DatosPersonales
    {
        static void Main(string[] args)
        {
            Bienvenido(args);
            
            Familia miembros = new Familia();
            miembros.Familiares();
            Informacion anime = new Informacion();
            anime.Datos();
            PatricioEstrtella datos = new PatricioEstrtella();
            datos.AmigoPatricio();
    
        }

        static void Bienvenido(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Responde las siguientes preguntas: ");
            Console.WriteLine("¿Cuál es el nombre completo de Bob Esponja? ");
            var nombreCompleto = Console.ReadLine();
            Console.WriteLine("¿Cómo se dice Bob Esponja en español? ");
            var nombre = Console.ReadLine();
            Console.WriteLine("¿Cuántos años tiene Bob Esponja? ");
            int edad1;
            while (true)
            {
                string edad = Console.ReadLine();
                if (!int.TryParse(edad, out edad1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };
            Console.WriteLine("¿Qué tipo de raza tiene Bob Esponja? ");
            var raza = Console.ReadLine();
            Console.WriteLine("¿Cuál es el sexo de Bob Esponja? ");
            var sexo = Console.ReadLine();
            Console.WriteLine("¿De qué color son los ojos de Bob Esponja? ");
            var ojos = Console.ReadLine();
            Console.WriteLine("¿Cuándo nació Bob Esponja? ");
            var nacimiento = Console.ReadLine();
            Console.WriteLine("¿Cuál es la ocupación de Bob Esponja? ");
            var ocupacion = Console.ReadLine();
            Console.WriteLine("¿Cuánto pesa Bob Esponja?  ");
            float peso1;
            while (true)
            {
                string peso = Console.ReadLine();
                if (!float.TryParse(peso, out peso1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };
            Console.WriteLine("¿Qué estatura tiene Bob Esponja?  ");
            float estatura1;
            while (true)
            {
                string estatura = Console.ReadLine();
                if (!float.TryParse(estatura, out estatura1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };
            
        }
       
    }
    
}
