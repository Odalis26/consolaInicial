using System;

namespace EjemploEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Profesor
            {
                Nombre = "Fernanda",
                Apellido = "Riofrío",
                Especialidad = "Inteligencia artificial"
            };

            Console.WriteLine(persona.Saludar());

            Asignatura asignatura = new Asignatura
            {
                Nombre = "Programación Visual",

            };

            Asignatura asignatura1 = new Asignatura
            {
                Nombre = "Diseño de interfaces",

            };
            Estudiante estudiante1 = new Estudiante
            {
                Nombre = "Rocio",

            };
            Estudiante estudiante2 = new Estudiante
            {
                Nombre = "Manuela",

            };

            Console.WriteLine("Asignatura: " + asignatura.Nombre);
            Console.WriteLine("Asignatura: " + asignatura1.Nombre);
            Console.WriteLine("Estudiante: " + estudiante1.Nombre);
            Console.WriteLine("Estudiante: " + estudiante2.Nombre);



        }
    }
}
