using System;
using System.Collections.Generic;

namespace NumeroHabitantes
{
    partial class Program
    {
        static void Main(string[] args)
        {
            AreaPolitica areaPolitica = new AreaPolitica();
            {
                areaPolitica.Nombre = "Ecuador";
                areaPolitica.TipoArea = TipoArea.Pais;
                areaPolitica.AreaPoliticas = new List<AreaPolitica>
                {
                    new AreaPolitica
                    {
                        Nombre = "Pichincha",
                        TipoArea = TipoArea.Provincia,
                        AreaPoliticas = new List<AreaPolitica>
                        {
                            new AreaPolitica
                            {
                                Nombre = "Quito",
                                TipoArea = TipoArea.Canton,
                                AreaPoliticas = new List<AreaPolitica>
                                {
                                    new AreaPolitica
                                    {
                                        Nombre = "La Merced",
                                        TipoArea = TipoArea.Parroquia,
                                        Habitantes = 7500

                                    },
                                    new AreaPolitica
                                    {
                                        Nombre = "Alangasi",
                                        TipoArea = TipoArea.Parroquia,
                                        Habitantes = 8200
                                    }
                                }

                            },

                            new AreaPolitica
                            {
                                Nombre = "Rumiñahui",
                                TipoArea = TipoArea.Canton,
                                AreaPoliticas = new List<AreaPolitica>
                                {
                                    new AreaPolitica
                                    {
                                        Nombre = "Conocoto",
                                        TipoArea = TipoArea.Parroquia,
                                        Habitantes = 6500
                                    }
                                }

                            },

                        }

                    }

                };
            };

            Console.WriteLine(areaPolitica.ObtenerNumeroHabitantes());
        }

    }

}