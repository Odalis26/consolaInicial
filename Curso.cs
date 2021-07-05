
using System.Collections.Generic;

namespace EjemploEntidades
{
    public class Curso

    {
        public int CursoaId { get; set; }
        public Nivel Nivel { get; set; }
        public Asignatura Asignatura { get; set; }
        public Jornada Jornada { get; set; }
        public Paralelo Paralelo { get; set; }
        public Profesor Profesor { get; set; }
        
       
    }

}