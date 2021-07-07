using System;
using System.Collections.Generic;
namespace GestionFarmacia
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var fecha = DateTime.Now;
            Empresa empresaRaiz = new()
            {
                Nombre = "empresaRaiz",
                FiltroPorCampos = new(),
                Empresas = new List<Empresa>()
                {
                    new Empresa()
                    {
                        Nombre = "HospiMedica",
                        Ruc = "1234567001",
                        Telefono = "02-2546985",
                        Proveedores = new List<Proveedor>()
                        {
                            new Proveedor(0, "Luis", "Saltos", "1754896523", "0985632001", "Maria Montaño", "Mariana Carcelen")
                            {
                                Provincia = "Pichincha",
                                NombreEmpresa = ""
                            },
                            new Proveedor(1, "Marcos", "Sanchez", "1754897523", "0985632111", "Maria Montaño", "Mariana Carcelen")
                            {
                                Provincia = "Pichincha",
                                NombreEmpresa = ""
                            },
                        },
                        Farmacias = new List<Farmacia>()
                        {
                            new Farmacia()
                            {
                                FarmaciaId = 0,
                                Nombre = "Sana Sana",
                                Ruc = "1245632001",
                                Telefono = "0985620123",
                                GeneradorDeArchivo = new GeneradorDeArchivos(),
                                Vendedores = new List<Vendedor>()
                                {
                                    new Vendedor(1, "Liz", "Perez", "1492157774", "0977772944", "Francisco Garcia","Joaquin Mancheno")
                                    {
                                        Cargo="Vendedor",
                                    },
                                    new Vendedor(2, "Manuela", "Perez", "1492157788", "0966662944", "Francisco Garcia","Joaquin Mancheno")
                                    {
                                        Cargo="Vendedor",
                                    }
                                },
                                Clientes = new List<Cliente>()
                                {
                                    new Cliente(0, "Manuel", "Riofrío", "1752442267", "0993556321","Angelica Hidrobo", "Carcelen")
                                    {
                                        Direccion = "Maria Montaño"
                                    }
                                },
                                Productos = new List<Producto>()
                                {
                                    new Producto()
                                    {
                                        ProductoId = 0,
                                        NombreProducto = "Protex",
                                        FechaVencimiento = fecha,
                                        Stock = 100,
                                        Precio = 1.25f
                                    },
                                    new Producto()
                                    {
                                        ProductoId = 1,
                                        NombreProducto = "Sin Gripal"
                                    }
                                }
                            },
                            new Farmacia()
                            {
                                FarmaciaId = 1,
                                Nombre = "Fibeca",
                                Ruc = "1245632001",
                                Telefono = "0985620123",
                                GeneradorDeArchivo = new GeneradorDeArchivos()
                            }
                        }
                    }
                }
            };

            for (int i = 0; i < empresaRaiz.Empresas.Count; i++)
            {
                Console.WriteLine($"{empresaRaiz.Empresas[i].EmpresaId} {empresaRaiz.Empresas[i].Nombre} {empresaRaiz.Empresas[i].Ruc} {empresaRaiz.Empresas[i].Telefono}");
                for (int z = 0; z < empresaRaiz.Empresas[i].Farmacias.Count; z++)
                {
                    Console.WriteLine($"{empresaRaiz.Empresas[i].Farmacias[i].Nombre} {empresaRaiz.Empresas[i].Farmacias[i].Telefono}");
                    if (empresaRaiz.Empresas[i].Farmacias[z].Clientes != null)
                    {
                        for (int a = 0; a < empresaRaiz.Empresas[i].Farmacias[z].Clientes.Count; a++)
                        {
                            Console.WriteLine($"{empresaRaiz.Empresas[i].Farmacias[z].Clientes[a].Nombre} {empresaRaiz.Empresas[i].Farmacias[z].Clientes[a].Apellido}");
                        }
                    }
                    if (empresaRaiz.Empresas[i].Farmacias[z].Vendedores != null)
                    {
                        for (int b = 0; b < empresaRaiz.Empresas[i].Farmacias[z].Vendedores.Count; b++)
                        {
                            Console.WriteLine($"{empresaRaiz.Empresas[i].Farmacias[z].Vendedores[b].Nombre} {empresaRaiz.Empresas[i].Farmacias[z].Vendedores[b].Apellido}");
                        }
                    }
                    if (empresaRaiz.Empresas[i].Farmacias[z].Productos != null)
                    {
                        for (int c = 0; c < empresaRaiz.Empresas[i].Farmacias[z].Productos.Count; c++)
                        {
                            Console.WriteLine($"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].NombreProducto} {empresaRaiz.Empresas[i].Farmacias[z].Productos[c].Precio}");
                        }
                    }
                    Console.WriteLine(empresaRaiz.Empresas[i].Farmacias[i].ToXml(empresaRaiz));
                }
            };

            Console.WriteLine("Actualizar?");
            while (true)
            {
                var veriificar = Console.ReadLine().ToUpper() == "SI" ? true : false;
                if (veriificar == true)
                {
                    MostrarDatosCrud(empresaRaiz);
                    Console.WriteLine("Digite el número de la empresa");
                    int numeroEmpresaElegido = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el número de la farmacia");
                    int numeroFarmaciaElegido = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el número del producto");
                    int numeroProductoElegido = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite datos del producto");
                    Console.WriteLine("Digite el nombre producto");
                    empresaRaiz.Empresas[numeroEmpresaElegido].Farmacias[numeroFarmaciaElegido].Productos[numeroProductoElegido].NombreProducto = Console.ReadLine();
                    Console.WriteLine("Digite el precio del producto");
                    empresaRaiz.Empresas[numeroEmpresaElegido].Farmacias[numeroFarmaciaElegido].Productos[numeroProductoElegido].Precio = float.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Eliminar Producro?");
            while (true)
            {
                var veriificar = Console.ReadLine().ToUpper() == "SI" ? true : false;
                if (veriificar == true)
                {
                    MostrarDatosCrud(empresaRaiz);
                    Console.WriteLine("Digite el número de la empresa");
                    int numeroEmpresaElegido = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el número de la farmacia");
                    int numeroFarmaciaElegido = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el número del producto");
                    int numeroProductoElegido = int.Parse(Console.ReadLine());
                    empresaRaiz.Empresas[numeroEmpresaElegido].Farmacias[numeroFarmaciaElegido].Productos.Remove(empresaRaiz.Empresas[numeroEmpresaElegido].Farmacias[numeroFarmaciaElegido].Productos[numeroProductoElegido]);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Crear Producro?");
            while (true)
            {
                var veriificar = Console.ReadLine().ToUpper() == "SI" ? true : false;
                if (veriificar == true)
                {
                    MostrarDatosCrud(empresaRaiz);
                    Console.WriteLine("Digite el número de la empresa");
                    int numeroEmpresaElegido = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el número de la farmacia");
                    int numeroFarmaciaElegido = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el número del producto");
                    int numeroProductoElegido = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite datos del producto");
                    Console.WriteLine("Digite el nombre producto");
                    string nombreProducto = Console.ReadLine();
                    Producto newproduct = new()
                    {
                        NombreProducto = "Chocolate"
                    };
                    empresaRaiz.Empresas[numeroEmpresaElegido].Farmacias[numeroFarmaciaElegido].Productos.Add(newproduct);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Filtrar por?");
            while (true)
            {
                var veriificar = Console.ReadLine().ToUpper() == "SI" ? true : false;
                if (veriificar == true)
                {
                    Console.WriteLine("Digite el nombre del campo para filtrar");
                    string campoElegido = Console.ReadLine();
                    Console.WriteLine("Digite el valor del campo para comparar");
                    string valorElegido = Console.ReadLine();
                    empresaRaiz.FiltradorPorCampos(campoElegido, valorElegido, empresaRaiz);
                }
                else
                {
                    break;
                }
            }

               var listMoneda = new List<Tuple<int, string, float>>()
                    {
                        Tuple.Create(1, "Moneda", 0.25f),
                        Tuple.Create(2, "Billete",20.00f),
                        Tuple.Create(3, "Moneda", 0.50f),
                        Tuple.Create(4, "Billete", 50.00f)
                    };
                foreach (Tuple<int, string, float> tuple in listMoneda)
                {
                    Console.WriteLine(tuple.Item1 + " " + tuple.Item2 + " " + tuple.Item3 + " ");
                }
                Console.ReadLine();
        }
        static void MostrarDatosCrud(Empresa empresaRaiz)
        {
            for (int i = 0; i < empresaRaiz.Empresas.Count; i++)
            {
                Console.WriteLine($"Empresa número: {empresaRaiz.Empresas[i].EmpresaId}");

                for (int z = 0; z < empresaRaiz.Empresas[i].Farmacias.Count; z++)
                {
                    Console.WriteLine($"Farmacia número: {empresaRaiz.Empresas[i].Farmacias[z].FarmaciaId}");

                    if (empresaRaiz.Empresas[i].Farmacias[z].Productos != null)
                    {
                        for (int c = 0; c < empresaRaiz.Empresas[i].Farmacias[z].Productos.Count; c++)
                        {
                            Console.WriteLine($"Id número: {empresaRaiz.Empresas[i].Farmacias[z].Productos[c].ProductoId}" +
                            $"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].Precio}" +
                            $"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].NombreProducto}");
                        }
                    }
                }
            };

        }
    }
}
