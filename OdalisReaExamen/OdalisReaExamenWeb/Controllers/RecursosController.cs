using Microsoft.AspNetCore.Mvc;

namespace OdalisReaExamenWeb.Controllers
{
    public class RecursosController : Controller
    {
        readonly string[] pinturas = new string[]
            {
                "El Grito II (La Edad de la Ira)",

                "El Grito de Munch",

                "La Gioconda"
            };
        [HttpPost]

        public IActionResult Index()
        {
            return View(pinturas);
        }
    }
}
