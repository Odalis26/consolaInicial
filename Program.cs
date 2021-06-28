
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
                                Valor="7"
                            }
                           
                        }
                    }
                    
                }
            };

            ManipuladorArbol manipuladorArbol = new ManipuladorArbol();
            Console.WriteLine($"La cantidad de hojas del arbol es: {manipuladorArbol.ContadorHojas(raiz)}");
            Console.WriteLine($"La cantidad de niveles del arbol es: {manipuladorArbol.ContarNiveles(raiz)}");
            Console.WriteLine($"La cantidad de nodos del arbol es: {manipuladorArbol.ContadorNodos(raiz)}");
            Console.WriteLine("Expresiones algebráicas: ");
            Console.WriteLine(manipuladorArbol.ImprimirArbolInfijo(raiz));
            Console.WriteLine(manipuladorArbol.ImprimirArbolInfijo2(raiz));
            Console.WriteLine(manipuladorArbol.ImprimirArbolPrefijo(raiz));
            Console.WriteLine(manipuladorArbol.ImprimirArbolSegundoPrefijo(raiz));
            Console.WriteLine(manipuladorArbol.ImprimirArbolPrefijo3(raiz));
        }
    }
}