using System;
namespace GestionFarmacia
{
    public class FiltroPorCampos
    {
        public void FiltradorPorCampos(string campo, string valor, Empresa empresaRaiz)
        {
            switch (campo)
            {
                case "Id":
                    {
                        for (int i = 0; i < empresaRaiz.Empresas.Count; i++)
                        {
                            for (int z = 0; z < empresaRaiz.Empresas[i].Farmacias.Count; z++)
                            {
                                if (empresaRaiz.Empresas[i].Farmacias[z].Productos != null)
                                {
                                    for (int c = 0; c < empresaRaiz.Empresas[i].Farmacias[z].Productos.Count; c++)
                                    {
                                        if (empresaRaiz.Empresas[i].Farmacias[z].Productos[c].ProductoId.ToString() == valor)
                                        {
                                            Console.WriteLine($"Id número: {empresaRaiz.Empresas[i].Farmacias[z].Productos[c].ProductoId}" +
                                                $"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].Precio}" +
                                                $"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].NombreProducto}");
                                        }
                                    }
                                }
                            }
                        };
                        break;
                    }
                case "NombreProducto":
                    {
                        for (int i = 0; i < empresaRaiz.Empresas.Count; i++)
                        {
                            for (int z = 0; z < empresaRaiz.Empresas[i].Farmacias.Count; z++)
                            {
                                if (empresaRaiz.Empresas[i].Farmacias[z].Productos != null)
                                {
                                    for (int c = 0; c < empresaRaiz.Empresas[i].Farmacias[z].Productos.Count; c++)
                                    {
                                        if (empresaRaiz.Empresas[i].Farmacias[z].Productos[c].NombreProducto.ToString() == valor)
                                        {
                                            Console.WriteLine($"Id número: {empresaRaiz.Empresas[i].Farmacias[z].Productos[c].ProductoId}" +
                                        $"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].Precio}" +
                                        $"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].NombreProducto}");
                                        }
                                    }
                                }
                            }
                        };
                        break;
                    }

                case "FechaVencimiento":
                    {
                        for (int i = 0; i < empresaRaiz.Empresas.Count; i++)
                        {
                            for (int z = 0; z < empresaRaiz.Empresas[i].Farmacias.Count; z++)
                            {
                                if (empresaRaiz.Empresas[i].Farmacias[z].Productos != null)
                                {
                                    for (int c = 0; c < empresaRaiz.Empresas[i].Farmacias[z].Productos.Count; c++)
                                    {
                                        if (empresaRaiz.Empresas[i].Farmacias[z].Productos[c].FechaVencimiento.ToString() == valor)
                                        {
                                            Console.WriteLine($"Id número: {empresaRaiz.Empresas[i].Farmacias[z].Productos[c].ProductoId}" +
                                            $"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].Precio}" +
                                            $"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].NombreProducto}");
                                        }
                                    }
                                }
                            }
                        };
                        break;
                    }
                case "Stock":
                    {
                        for (int i = 0; i < empresaRaiz.Empresas.Count; i++)
                        {
                            for (int z = 0; z < empresaRaiz.Empresas[i].Farmacias.Count; z++)
                            {
                                if (empresaRaiz.Empresas[i].Farmacias[z].Productos != null)
                                {
                                    for (int c = 0; c < empresaRaiz.Empresas[i].Farmacias[z].Productos.Count; c++)
                                    {
                                        if (empresaRaiz.Empresas[i].Farmacias[z].Productos[c].Stock.ToString() == valor)
                                        {
                                            Console.WriteLine($"Id número: {empresaRaiz.Empresas[i].Farmacias[z].Productos[c].ProductoId}" +
                                            $"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].Precio}" +
                                            $"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].NombreProducto}");
                                        }
                                    }
                                }
                            }
                        };
                        break;
                    }

                case "Precio":
                    {
                        for (int i = 0; i < empresaRaiz.Empresas.Count; i++)
                        {
                            for (int z = 0; z < empresaRaiz.Empresas[i].Farmacias.Count; z++)
                            {
                                if (empresaRaiz.Empresas[i].Farmacias[z].Productos != null)
                                {
                                    for (int c = 0; c < empresaRaiz.Empresas[i].Farmacias[z].Productos.Count; c++)
                                    {
                                        if (empresaRaiz.Empresas[i].Farmacias[z].Productos[c].Precio.ToString() == valor)
                                        {
                                            Console.WriteLine($"Id número: {empresaRaiz.Empresas[i].Farmacias[z].Productos[c].ProductoId}" +
                                            $"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].Precio}" +
                                            $"{empresaRaiz.Empresas[i].Farmacias[z].Productos[c].NombreProducto}");
                                        }
                                    }
                                }
                            }
                        };
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Los campos son incorrectos");
                        break;
                    }
            }

        }
    }
}