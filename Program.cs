using System;

using System.Collections.Generic;

namespace Habitantes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pais pais1 = new Pais
            {
                Nombre = "Ecuador",
                PaisId = 1
            };

            pais1.Provincias = new List<Provincia>();
            var provincia1 = new Provincia();
            provincia1.Nombre = "Imbabura";
            var provincia2 = new Provincia();
            provincia2.Nombre = "Pichincha";
            pais1.Provincias = new List<Provincia>(){
                    provincia1,
                    provincia2
                };
            Console.WriteLine(pais1.Provincias);
            var canton1 = new Canton();
            canton1.Nombre = "Ibarra";
            var canton2 = new Canton();
            canton2.Nombre = "Cayambe";
            provincia2.Cantones = new List<Canton>();
            provincia2.Cantones.Add(canton1);
            provincia2.Cantones.Add(canton2);
            var parroquia1 = new Parroquia();
            parroquia1.Nombre = "San Francisco";
            var parroquia2 = new Parroquia();
            parroquia2.Nombre = "Gonzales Suarez";
            parroquia1.Habitantes = 400;
            parroquia2.Habitantes = 700;
            canton1.Parroquias = new List<Parroquia>();
            canton1.Parroquias.Add(parroquia1);
            canton1.Parroquias.Add(parroquia2);

            Console.WriteLine($" En las 2 parroquias hay: {pais1.ObtenerNumeroDeHabitantes()} habitantes");

        }
    }
}
