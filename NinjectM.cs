using Ninject.Modules;

namespace InyeccionIndependencia
{
    class NinjectM : NinjectModule
    {
        public override void Load()
        {
            Bind<Creador>().To<CreadorDeArchivoXml>();
        }
    }
}