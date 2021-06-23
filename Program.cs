using System;

namespace DatosPersonales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir 10 datos personales
            SaludoInicial(args);
            Console.WriteLine("Bienvenido");

            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();

            int edad = IngresarEdad();

            Console.Write("Usted, ¿Cuánto pesa?: ");

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

            Console.Write("¿Su cantante favorito es Justin Bieber?: ");
            bool cantanteFavorito = Console.ReadLine().ToUpper() == "SI";

            Console.Write("¿Qué fecha es hoy?: "); 
            DateTime fecha1;
            while (true)
            {
                string fecha = Console.ReadLine();
                if (!DateTime.TryParse(fecha, out fecha1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };

            Console.Write("¿Cuál es su estatura?: ");
            float altura1;
            while (true)
            {
                string altura = Console.ReadLine();
                if (!float.TryParse(altura, out altura1))
                {
                    Console.Write("Ingrese un valor numérico: ");
                }
                else
                {
                    break;
                };

            };

            Console.Write("¿Cuál es su deporte favorito?: ");
            string deporte = Console.ReadLine();

            Console.Write("¿Cuál es su hobbit favorito?: ");
            string hobbit = Console.ReadLine();

            Console.Write("¿Cuál es su sueldo?: ");
            string sueldo = Console.ReadLine();
            double sueldo1 = double.Parse(sueldo);

            Console.Write("¿En qué semestre está?: ");
            string semestre = Console.ReadLine();

            var persona = new Persona
            {
                nombre = nombre,
                edad = edad,
                peso = peso1,
                esAficionadoAJustinBieber = cantanteFavorito,
                fechaDeCreacionRegistro = fecha1,
                estatura = altura1,
                deporteFavorito = deporte,
                hobbitFavorito = hobbit,
                sueldoMensual = sueldo1,
                semestre = semestre
            };

            Console.WriteLine("Su información es la siguiente: ");
            Console.Write($" Su nombre es: {persona.nombre} ");
            Console.Write($" Su edad es: {persona.edad} ");
            Console.Write($" Su peso es: {persona.peso} ");
            Console.Write($"¿Su cantante favorito es Justin Bieber?: {persona.esAficionadoAJustinBieber} ");
            Console.Write($"La fecha De Creacion Del Registro: {persona.fechaDeCreacionRegistro} ");
            Console.Write($"Su estatura: {persona.estatura} ");
            Console.Write($"Su deporte favorito es: {persona.deporteFavorito} ");
            Console.Write($"Su hobitt favorito es:{persona.hobbitFavorito} ");
            Console.Write($"Su sueldo es: {persona.sueldoMensual} ");
            Console.Write($"Su semestre es:  {persona.semestre}  ");
            Console.WriteLine("Gracias por participar");
            Console.ReadKey();
        }

        static void SaludoInicial(string[] args)
        {
            if (args.Length > 3)
            {
                Console.WriteLine("Hola " + args[0] + ' ' + args[1] + ' ' + args[2] + ' ' + args[3]);
            }
            else
            {
                Console.WriteLine("Hola desconocido");
            }
            Console.WriteLine("¿Cómo estas?");
            var estado = Console.ReadLine();
            Console.WriteLine("mmmmm,entiendo");
            Console.ReadKey();
        }
        static int IngresarEdad()
        {
            Console.Write("Ingrese su edad: ");
            int edad1;
            while (true)
            {
                string edad = Console.ReadLine();
                if (!int.TryParse(edad, out edad1))
                {
                    Console.Write("Ingrese un valor numérico ");
                }
                else
                {
                    break;
                };
            };
            return edad1;
        }

    }
}
