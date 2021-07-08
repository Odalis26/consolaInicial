using System;
using Ninject;
using Unity;

namespace InyeccionIndependencia
{
    class Program
    {
        static GestorArchivo GestorArchivo;

        static void Main(string[] args)
        {
            Init();

            Producto producto = new()
            {
                ProductoId = 1,
                Nombre = "Gel Ego",
                Precio = 1.50f,
            };

            Console.WriteLine($"Utilizando Unity => {GestorArchivo.CrearArchivo(producto)}");

            Ninject.Modules.INinjectModule module = new NinjectM();
           
            IReadOnlyKernel nucleo = new KernelConfiguration(module).BuildReadonlyKernel();
            
        

            var gestorArchivo = nucleo.Get<GestorArchivo>();
            Console.WriteLine($"Utilizando Ninject => {gestorArchivo.CrearArchivo(producto)}");
            Console.ReadKey();
        }
        static void Init()
        {
            try
            {
                var container = new UnityContainer();
                container.RegisterType<Creador, CreadorArchivoTxt>();
                GestorArchivo = container.Resolve<GestorArchivo>();
            }
            catch (Exception e)
            {
                if (GestorArchivo == null)
                {
                    System.Diagnostics.Trace.TraceError(e.Message);
                    Console.WriteLine("Generador de archivos no inyectado!");
                }
                
            }
        }

    }
}
