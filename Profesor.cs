using System;

namespace EjemploEntidades
{
    public class Profesor : Persona
    {
        public Profesor():base("Carlos","Anibal")
        {
           
        }
        public int ProfesorId { get; set; }
        public string Especialidad { get; set; }
       
    }
}