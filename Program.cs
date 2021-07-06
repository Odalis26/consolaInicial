using System;

namespace EjemploEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Profesor()
            {
                Nombre = "Fernanda",
                Apellido = "Riofrío",
                Especialidad = "Inteligencia artificial"
            };

            Console.WriteLine(persona.Saludar());

            Asignatura asignatura = new Asignatura()
            {
                Nombre = "Programación Visual"

            };

            Asignatura asignatura1 = new Asignatura()
            {
                Nombre = "Diseño de interfaces"

            };
            Estudiante estudiante1 = new Estudiante()
            {
                Nombre = "Rocio",
                Apellido= "Rea"

            };
            Estudiante estudiante2 = new Estudiante()
            {
                Nombre = "Manuela",
                Apellido = "Martinez"

            };

            Console.WriteLine("Asignatura #1: " + asignatura.Nombre);
            Console.WriteLine("Asignatura:#2: " + asignatura.Nombre);
            Console.WriteLine($"Información del profesor: \nNombre: {persona.Nombre} \nApellido:{persona.Apellido} \nEspecialidad:{persona.Especialidad}");
            Console.WriteLine($"Información del Estudiante: \nNombre: {estudiante1.Nombre} \nApellido:{estudiante1.Apellido}");
            Console.WriteLine($"Información del Estudiante: \nNombre: {estudiante2.Nombre} \nApellido:{estudiante2.Apellido}");
            
        }
    }
}
