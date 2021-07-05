using System;

namespace EjemploEntidades
{
    public class Asignatura

    {
        public  int AsignaturaId { get; set; }
    
        public string Nombre { get; set; }
        public Nivel Nivel { get; set; }
    }

}