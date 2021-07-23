using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using OdalisReaExamenWeb.Emptities;
using System;
using System.Linq;

namespace OdalisReaExamenWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run(); //Para que corra el programa
            Nodo arbol = new Nodo { Valor = 10.5f };
            var nodo3 = new Nodo { Valor = 55.2f };
            var nodo4 = new Nodo { Valor = -7f };
            var nodo5 = new Nodo { Valor = 3.1e2 };
            var nodo6 = new Nodo { Valor = -7f };
            var nodo1 = new Nodo { Valor = 15.2f };

            nodo1.NodosHijos.Add(nodo3);
            nodo1.NodosHijos.Add(nodo4);

            var nodo2 = new Nodo { Valor = -7f };
            nodo2.NodosHijos.Add(nodo5);
            nodo2.NodosHijos.Add(nodo6);
            arbol.NodosHijos.Add(nodo1);
            arbol.NodosHijos.Add(nodo2);

            Console.WriteLine(Nodo.Navegar(arbol));

            string[] languages = { "Lisp", "ICI", "C#", "Angular", "F#" };
            var result = string.Join(string.Empty, languages.Reverse().Select(s => s[0]));
            Console.WriteLine(result);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
