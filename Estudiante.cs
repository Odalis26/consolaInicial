using System;

namespace EjemploEntidades
{
    public class Estudiante : Persona
    {
        public Estudiante():base("Jorge", "Lopez")
        {
           
        }
        public int EstudianteId { get; set; }
       
    }
}