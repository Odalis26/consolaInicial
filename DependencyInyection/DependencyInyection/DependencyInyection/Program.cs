﻿using Abstraccion;
using System;

namespace DependencyInyection
{
    class Program
    {
        static void Main(string[] args)
        {
            Libreria libreria = new Libreria();

            var libro = new Libro { LibroId = 1, Titulo = "La dama tapada", Autor = "Josué Miranda" };
            libreria.Libros.Add(libro);

            libreria.Impresora = new ImpresoraTexto(); // Inyectando por propiedad
            Console.WriteLine(libreria.Imprimir(libro.LibroId));

            libreria.Impresora = new ImpresoraXml1(); // Inyectando por propiedad
            Console.WriteLine(libreria.Imprimir(libro.LibroId));
        }
    }
}