using System;

namespace AppPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Odalis";
            persona.Apellido ="Rea";
            persona.Saludar(); 
            Console.WriteLine("Nombre:" + persona.Nombre);
            Console.WriteLine("Apellido:" + persona.Apellido);
            Console.WriteLine("Saludar: " + persona.Saludar());
            persona.Dormir();
        }
    }
}
