
using System;

namespace Tarea2Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Nodo raiz = new Nodo()
            {

                Valor = "*",
                nivel=0,
                Hijos ={
                    new Nodo{
                        Valor="/",
                        Hijos={
                            new Nodo{
                                Valor="5"
                            },
                            new Nodo{
                                Valor ="9"
                            }
                        }
                    },
                    new Nodo{
                        Valor ="+",
                        Hijos={
                            new Nodo{
                                Valor="19"
                            },
                            new Nodo{
                                Valor="20"
                            }
                        }
                    },
                    new Nodo{
                        Valor="-",
                        Hijos={
                            new Nodo{
                                Valor="7"
                            },
                            new Nodo{
                                Valor="1"
                            }
                           
                        }
                    }
                    


                },
            };

            ManipuladorArbol ManipuladorArbol = new ManipuladorArbol();
            Console.WriteLine($"La cantidad de hojas del arbol es: {ManipuladorArbol.ContadorHojas(raiz)}");
            Console.WriteLine($"La cantidad de niveles del arbol es: {ManipuladorArbol.ContarNiveles(raiz)}");
            Console.WriteLine($"La cantidad de nodos del arbol es: {ManipuladorArbol.ContadorNodos(raiz)}");


        }
    }
}